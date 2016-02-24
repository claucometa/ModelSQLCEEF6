using System;
using System.Drawing;

namespace CFSqlCe.Domain.Views
{
    public interface IBaseView
    {
        Guid Id { get; set; }
        decimal Valor { get; set; }
        string Nome { get; }
        decimal Min { get; }
        decimal Max { get; }
        string Unit { get; }
        string Summary { get; }
        Bitmap Graph { get; }
    }
}
