using System;
using System.Drawing;
using CFSqlCe.Domain.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFSqlCe.Domain.Views
{
    public class BaseView : IBaseView
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }

        public long LaudoId { get; set; }
        public virtual Laudo Laudo { get; set; }

        public long PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public long LastKey { get; set; }

        public string LaudoName
        {
            get
            {
                return (Laudo == null ? "N/A" : Laudo.SomeName);
            }
        }

        public BaseView()
        {
            Id = Guid.NewGuid();
        }

        public Bitmap Graph
        {
            get
            {
                decimal quociente = Valor - Min;
                decimal divisor = Max - Min;
                if (divisor == 0) return null;
                var x = (double)(quociente / divisor);
                return MyIndicator.DoImage((int) (x*100));
            }
        }

        public virtual string Nome
        {
            get { throw new NotImplementedException(); }
        }

        public virtual decimal Min
        {
            get { throw new NotImplementedException(); }
        }

        public virtual decimal Max
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string Unit
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string Summary
        {
            get { throw new NotImplementedException(); }
        }
    }
}
