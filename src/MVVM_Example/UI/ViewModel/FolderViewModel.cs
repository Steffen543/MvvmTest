using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using MVVM_Service;
using MVVM_Shared.DTO;

namespace MVVM_Example.UI.ViewModel
{
    public class FolderViewModel : ViewModelBase
    {
        public int Id
        {
            get { return GetProperty(() => Id); }
            set { SetProperty(() => Id, value); }
        }

        public string Name
        {
            get { return GetProperty(() => Name); }
            set { SetProperty(() => Name, value); }
        }

        public string Description
        {
            get { return GetProperty(() => Description); }
            set { SetProperty(() => Description, value); }
        }

        public int ParentId
        {
            get { return GetProperty(() => ParentId); }
            set { SetProperty(() => ParentId, value); }
        }

        private FolderDTO FolderDTO => new FolderDTO(Id, Name, Description, ParentId);

        public FolderViewModel(int id, string name, string description, int parentId)
        {
            Id = id;
            Name = name;
            Description = description;
            ParentId = parentId;
        }

        [Command]
        public void Save()
        {
            var service = new MvvmService();
            service.UpdateFolder(FolderDTO);
        }
        public bool CanSave()
        {
            return !String.IsNullOrEmpty(Name);
        }

        [Command]
        public void Delete()
        {
            var service = new MvvmService();
            service.DeleteFolder(FolderDTO);
        }
    }
}
