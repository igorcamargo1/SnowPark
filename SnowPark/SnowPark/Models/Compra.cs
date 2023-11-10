using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnowPark.Models;

[Table("Tbl_Compra")]
public class Compra
{
    [Column("CompraId"), HiddenInput]
    public int CompraId { get; set; }

    [Required, MaxLength(80)]
    public string? Nome { get; set; }

    [Required, MaxLength(11)]
    public string? Cpf { get; set; }

    [Column("Dt_Visita"), Display(Name = "Data de Visita"),
         DataType(DataType.Date)]
    public DateTime DataVisita { get; set; }

    [Column("Ds_Servico"), Required, Display(Name = "Serviço")]
    public Servico Servico { get; set; }

    [Required, MaxLength(11)]
    public string? Telefone { get; set; }

    [Required, Column("Tp_Pagamento")]
    public TipoPagamento TipoPagamento { get; set; }
}

public enum Servico
{
    Teleferico, SnowMobile, PacoteCompleto, Esquiar
}

public enum TipoPagamento
{
    Dinheiro, Cartão, Pix
}
