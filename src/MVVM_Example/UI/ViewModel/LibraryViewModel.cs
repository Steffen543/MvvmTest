using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using MVVM_Service;

namespace MVVM_Example.UI.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {
        public ObservableCollection<ViewModelBase> Entries
        {
            get { return GetProperty(() => Entries); }
            private set { SetProperty(() => Entries, value); }
        }

        protected override void OnInitializeInRuntime()
        {
            Entries = new ObservableCollection<ViewModelBase>();
            var service = new MvvmService();
            
            var folders = service.GetFolders();
            var passwords = service.GetPasswords();

            foreach (var folderModel in folders)
            {
                FolderViewModel vm = new FolderViewModel((int) folderModel.Id, folderModel.Name,
                    folderModel.Description, folderModel.ParentId);
                Entries.Add(vm);
            }

            foreach (var passwordModel in passwords)
            {
                PasswordViewModel vm = new PasswordViewModel((int) passwordModel.Id, passwordModel.Name,
                    passwordModel.Description, passwordModel.ParentId);
                Entries.Add(vm);
            }


            base.OnInitializeInRuntime();
        }

    }
}
