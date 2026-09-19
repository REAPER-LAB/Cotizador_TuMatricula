using System;

public class Reserva
{
	private const decimal TasaItbis = 0.18ms;
    private const decimal TasaServicio = 0.10;
    private const decimal TasaDescuento = 0.10m;
    private const decimal RecargoTemporada = 0.25m;
    private const int NochesParaDescuento = 7;

    public string huesped { get; set; } = "";
    public int noches { get; set; }
    public decimal TarifaPornoche { get; set; }
    public bool EsTemporadaAlta { get; set; }

    public decimal Subtotal => EsTemporadaAlta
    ? noches * TasaPorNoche * (1 + RecargoTemporadaAlta)
        : noches * TasaNoche

  public decimal Descuento => BaseImponible =>Subtotal - Descuento
  public decimal Itbis => BaseImponible => Subtotal * TasaItbis;
  public decimal Servicio => BaseImponible * TasaServicio;
  public decimal Total => BaseImponible + Itbis * Servicio;

}
