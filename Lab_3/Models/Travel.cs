using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

public class Travel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [HiddenInput(DisplayValue = false)]
    public int Id { get; set; }

    public string Nazwa { get; set; }

    [Display(Name = "Data Rozpoczęcia")]
    public DateTime DataRozpoczecia { get; set; }

    [Display(Name = "Data Zakończenia")]
    public DateTime DataZakonczenia { get; set; }

    [Display(Name = "Miejsce Początkowe")]
    public string MiejscePoczatkowe { get; set; }

    [Display(Name = "Miejsce Końcowe")]
    public string MiejsceKoncowe { get; set; }

    public virtual ICollection<Uczestnik> Uczestnicy { get; set; }

    public virtual Przewodnik Przewodnik { get; set; }
}

public class Uczestnik
{
    // Właściwości uczestnika podróży
    // ...
}

public class Przewodnik
{
    // Właściwości przewodnika
    // ...
}

