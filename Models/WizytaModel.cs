using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace TaskManager.Models
{
    [Table("Wizyty")]
    public class WizytaModel
    {
       [Key]
        
        public int WizytaId { get; set; }
        [DisplayName("Nazwa wizyty")]
        [Required(ErrorMessage ="Pole nazwa jest wymagane.")]
        public string Nazwa { get; set; }


        [Required(ErrorMessage = "Data jest wymagana.")]
        [Display(Name = "Umówiona data")]
        public DateTime JoinDate { get; set; }
        [Required(ErrorMessage = "Opis  jest wymagany.")]
        [Display(Name = "Opis badania")]
        public string OpisBadania { get; set; }

        [Required(ErrorMessage = "Imię  jest wymagane.")]
        [Display(Name = "Imę Pacjenta")]
        public string ImiePacjenta { get; set; }

        [Required(ErrorMessage = "Nazwisko  jest wymagane.")]
        [Display(Name = "Nazwisko Pacjenta")]
        public string NazwiskoPacjenta { get; set; }

        [Required(ErrorMessage = "Pesel  jest wymagany.")]
        [Display(Name = "Pesel Pacjenta")]
        public string PeselPacjenta { get; set; }

    }
}
