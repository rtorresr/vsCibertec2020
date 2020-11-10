using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    [DataContract]
    [Table("Artist")]
    public class Artist
    {
        [DataMember]
        [Key]
        public int ArtistId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [IgnoreDataMember]
        public virtual List<Album> Album { get; set; }
    }
}
