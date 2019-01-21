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
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IService1" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IMvvmService
    {

        [OperationContract]
        List<PasswordDTO> GetPasswords();

        [OperationContract]
        List<FolderDTO> GetFolders();

        [OperationContract]
        void UpdatePassword(PasswordDTO password);

        [OperationContract]
        void DeletePassword(PasswordDTO password);

        [OperationContract]
        void UpdateFolder(FolderDTO password);

        [OperationContract]
        void DeleteFolder(FolderDTO password);



    }


  
}
