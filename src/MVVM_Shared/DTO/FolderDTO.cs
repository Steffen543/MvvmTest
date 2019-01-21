

using System.Runtime.Serialization;

namespace MVVM_Shared.DTO
{
    [DataContract]
    public class FolderDTO
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int ParentId { get; set; }

        public FolderDTO(int id, string name, string description, int parentId)
        {
            Id = id;
            Name = name;
            Description = description;
            ParentId = parentId;
        }
    }
}
