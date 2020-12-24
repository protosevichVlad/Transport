using System.Collections.Generic;
using System.Linq;
using IronXL;
using View;
using Model;

namespace Presenter
{
    public class ShowLogsPresenter
    {
        private IShowLogsView _view;
        public ShowLogsPresenter(IShowLogsView view)
        {
            _view = view;
            List<string> names = new List<string>();
            foreach (var vehicle in ApplicationContext.Vehicles)
            {
                names.Add($"{vehicle.VehicleBrand} {vehicle.Model}");
            }

            _view.SetVehicles(names);
        }

        public void Submit()
        {
            var index = _view.GetIndexVehicles();
            if (index == -1)
            {
                return;
            }
            
            var vehicle = ApplicationContext.Vehicles[index];

            if (_view.GetExportTypes().Contains("txt"))
            {
                System.IO.File.WriteAllLines($@".\Log_{vehicle.VehicleBrand}_{vehicle.Model}.txt",
                    vehicle.LogString.ToArray());
            }

            if (_view.GetExportTypes().Contains("word"))
            {
                System.IO.File.WriteAllLines($@".\Log_{vehicle.VehicleBrand}_{vehicle.Model}.doc",
                    vehicle.LogString.ToArray());
            }
            
            if (_view.GetExportTypes().Contains("window"))
            {
                _view.OpenLog(vehicle.LogString);
            }
            
            if (_view.GetExportTypes().Contains("excel"))
            {
                var newXLFile = WorkBook.Create(ExcelFileFormat.XLSX);
                newXLFile.Metadata.Title = "Log_{vehicle.VehicleBrand}_{vehicle.Model}";
                var newWorkSheet = newXLFile.CreateWorkSheet($"{vehicle.VehicleBrand}_{vehicle.Model}");
                for (int i = 1; i <= vehicle.LogString.Count; i++)
                {
                    //write the Dynamic value in one row
                    List<string> row = vehicle.LogString[i - 1].Split('#').ToList();
                    newWorkSheet["A" + i].Value = row[0];
                    //write the Dynamic value in another row
                    newWorkSheet["B" + i].Value = row[1];
                }

                newXLFile.SaveAs($"Log_{vehicle.VehicleBrand}_{vehicle.Model}.xlsx");
            }
        }

        
    }
}
