using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DagZaf.Model;
using DagZaf.ViewModel;

namespace DagZaf.ViewModel
{
    public class TodoViewModel : BaseViewModel
    {
        #region Attributes

        public object listViewSource;

        #endregion

        #region Properties

        public object ListViewSource
        {
            get { return this.listViewSource; }
            set { SetValue(ref this.listViewSource, value); }
        }

        #endregion

        #region Methods

        public async Task LoadData()
        {
            this.ListViewSource = await App.Database.GetUser();
        }

        #endregion

        #region Constructor
        public TodoViewModel()
        {
            _ = LoadData();
        }
        #endregion
    }
}
