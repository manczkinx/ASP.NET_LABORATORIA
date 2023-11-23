using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models;

public class Komputer
{
    [HiddenInput]
    public int id { get; set; }
    // Nazwa,procesor,pamiec,karta graficzna, producent, data produkcji


    [Required(ErrorMessage = "Prosze podaæ nazwê komputera.")]
    public string Name { get; set; }

    [Range(1, 128, ErrorMessage = "Wartoœæ {0} musi byæ pomiêdzy {1} a {2}.")]
    public int Memo { get; set; }

    [Required(ErrorMessage = "Musisz podaæ nazwê karty graficznej!")]
    public string Graphic { get; set; }

    [Required(ErrorMessage = "Musisz podaæ nazwê producenta!")]
    public string Producent { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime Date { get; set; }
}
