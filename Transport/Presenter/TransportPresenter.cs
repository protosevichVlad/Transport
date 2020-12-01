using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.View;

namespace Transport.Presenter
{
    class TransportPresenter
    {
        private TransportView _view;

        public TransportPresenter(TransportView view)
        {
            _view = view;
        }

    }
}
