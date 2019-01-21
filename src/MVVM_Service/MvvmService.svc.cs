using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MVVM_Shared.DTO;

namespace MVVM_Service
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC- und der Konfigurationsdatei ändern.
    // HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts Service1.svc oder Service1.svc.cs im Projektmappen-Explorer aus, und starten Sie das Debuggen.
    public class MvvmService : IMvvmService
    {
        public List<PasswordDTO> GetPasswords()
        {
            var returnList = new List<PasswordDTO>();

            returnList.Add(new PasswordDTO(100, "Password 1", "Description 1", 1));
            returnList.Add(new PasswordDTO(100, "Password 2", "Description 2", 2));
            returnList.Add(new PasswordDTO(100, "Password 3", "Description 3", 3));
            returnList.Add(new PasswordDTO(100, "Password 4", "Description 4", 3));
            returnList.Add(new PasswordDTO(100, "Password 5", "Description 5", 4));
            returnList.Add(new PasswordDTO(100, "Password 6", "Description 6", 6));

            return returnList;

        }

        public List<FolderDTO> GetFolders()
        {
            var returnList = new List<FolderDTO>();

            returnList.Add(new FolderDTO(1, "Folder 1", "Description 1", 0));
            returnList.Add(new FolderDTO(2, "Folder 2", "Description 2", 0));
            returnList.Add(new FolderDTO(3, "Folder 3", "Description 3", 1));
            returnList.Add(new FolderDTO(4, "Folder 4", "Description 4", 1));
            returnList.Add(new FolderDTO(5, "Folder 5", "Description 5", 2));
            returnList.Add(new FolderDTO(6, "Folder 6", "Description 6", 2));

            return returnList;
        }

        public void UpdatePassword(PasswordDTO password)
        {
            if(password.Id != null)
                Console.WriteLine("Password Update");
            else
                Console.WriteLine("Password New");
        }

        public void DeletePassword(PasswordDTO password)
        {
            Console.WriteLine("Password Delete");
        }

        public void UpdateFolder(FolderDTO folder)
        {
            if (folder.Id != null)
                Console.WriteLine("Folder Update");
            else
                Console.WriteLine("Folder New");
        }

        public void DeleteFolder(FolderDTO password)
        {
            Console.WriteLine("Folder Delete");
        }
    }
}
