using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Emprego{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public double Salario { get; set; }
    public string Profissao { get; set; }
    

    public Emprego(double salario, string profissao)
    {
        this.Salario = salario;
        this.Profissao = profissao;
    }

    private Emprego() { }
}