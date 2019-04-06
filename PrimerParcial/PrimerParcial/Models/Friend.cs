using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimerParcial.Models
{
    public enum FriendType
    {
        Conocido,
        CompañeroEstudio,
        ColegiadeTrabajo,
        Amigo,
        AmigodeInfancia,
        Pariente
    }

    public enum StatusType
    {
        Activo,
        Inactivo
    }


    public class Friend
    {
        [Key]
        public int FriendId { get; set; }

        [Required]

        public String Nickname { get; set; }

        public DateTime BirthDay { get; set; }

        [Required]

        public FriendType Amigo { get; set; }

        public StatusType Status { get; set; }

    }

}