using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using MVVM_Service;
using MVVM_Shared.DTO;

namespace MVVM_Example.UI.ViewModel
{
    public class PasswordViewModel : ViewModelBase
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

        private PasswordDTO PasswordDTO => new PasswordDTO(Id, Name, Description, ParentId);

        public PasswordViewModel(int id, string name, string description, int parentId)
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
            service.UpdatePassword(PasswordDTO);
        }
        public bool CanSave()
        {
            return !String.IsNullOrEmpty(Name);
        }

        [Command]
        public void Delete()
        {
            var service = new MvvmService();
            service.DeletePassword(PasswordDTO);
        }
    }
}
