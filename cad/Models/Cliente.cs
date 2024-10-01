using System.ComponentModel.DataAnnotations;
namespace cad.Models;
public class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O telefone é obrigatório")]
    [Phone]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "O logradouro é obrigatório")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "O número é obrigatório")]
    public string Numero { get; set; }

    [Required(ErrorMessage = "O complemento é obrigatório")]
    public string Complemento { get; set; }

    [Required(ErrorMessage = "O bairro é obrigatório")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "A cidade é obrigatória")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "O estado é obrigatório")]
    public string Estado { get; set; }

    [Required(ErrorMessage = "O CEP é obrigatório")]
    public string CEP { get; set; }
}
