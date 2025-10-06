using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clickbait_usuarios.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public string Telefone { get; set; }

        [Required]
        public Estado Estado { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        [NotMapped]
        public string ConfirmarSenha { get; set; }

        public Perfil Perfil { get; set; }
    }

    public enum Estado
    {
        Acre,
        Alagoas,
        Amapá,
        Amazonas,
        Bahia,
        Ceará,
        DistritoFederal,
        EspíritoSanto,
        Goiás,
        Maranhão,
        MatoGrosso,
        MatoGrossodoSul,
        MinasGerais,
        Pará,
        Paraíba,
        Paraná,
        Pernambuco,
        Piauí,
        RiodeJaneiro,
        RioGrandedoNorte,
        RioGrandedoSul,
        Rondônia,
        Roraima,
        SantaCatarina,
        SãoPaulo,
        Sergipe,
        Tocantins
    }
    public enum Perfil
    {
        [Display(Name = "Administrador")]
        Administrador,
        [Display(Name = "Usuario")] 
        Usuario
    }
}
