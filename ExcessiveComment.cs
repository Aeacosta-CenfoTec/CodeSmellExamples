public class InvoiceCalculator
{
    public decimal CalculateTotal(List<InvoiceItem> items)
    {
        decimal total = 0;

        foreach (var item in items)
        {
            decimal subtotal = item.Quantity * item.UnitPrice;

            total += subtotal;
        }

        return total;
    }

    public bool HasDiscount(decimal total)
    {
        return total > DiscountThreshold;
    }
}

    private const decimal DiscountThreshold = 1000m;

    /// <summary>
    /// Calcula el total de todos los items de la factura.
    /// </summary>
    /// <param name="items">Lista de items de la factura.</param>
    /// <returns>Suma de subtotales (cantidad por precio unitario).</returns>
    /// <summary>
    /// Determina si el total supera el umbral para aplicar descuento.
    /// </summary>
