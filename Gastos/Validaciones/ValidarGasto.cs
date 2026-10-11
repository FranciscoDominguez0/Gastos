using Gastos.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastos.Validaciones
{
    internal class ValidarGasto
    {
        public static bool IntentarValidar(
            string concepto,
            string categoria,
            string montoTexto,
            string fechaTexto,
            out Gasto gasto,
            out string mensaje)
        {
            gasto = null;
            mensaje = string.Empty;

            concepto = concepto?.Trim() ?? string.Empty;
            categoria = categoria?.Trim() ?? string.Empty;
            montoTexto = montoTexto?.Trim() ?? string.Empty;
            fechaTexto = fechaTexto?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(concepto))
            {
                mensaje = "Debe ingresar el concepto del gasto.";
                return false;
            }

            if (concepto.Length > 150)
            {
                mensaje = "El concepto no puede superar 150 caracteres.";
                return false;
            }

            if (categoria != "Transporte" &&
                categoria != "Alimentación" &&
                categoria != "Servicios")
            {
                mensaje = "Seleccione una categoría válida.";
                return false;
            }

            if (!decimal.TryParse(
                montoTexto,
                NumberStyles.AllowDecimalPoint |
                NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture,
                out decimal monto))
            {
                mensaje = "El monto debe ser un número decimal válido.";
                return false;
            }

            if (monto <= 0 || monto > 99999999.99m)
            {
                mensaje = "El monto debe ser mayor que cero y no superar 99999999.99.";
                return false;
            }

            if (decimal.Round(monto, 2) != monto)
            {
                mensaje = "El monto debe tener máximo dos decimales.";
                return false;
            }

            if (!DateTime.TryParseExact(
                fechaTexto,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime fecha))
            {
                mensaje = "La fecha debe tener el formato yyyy-MM-dd.";
                return false;
            }

            gasto = new Gasto
            {
                Concepto = concepto,
                Categoria = categoria,
                Monto = monto,
                Fecha = fecha
            };

            return true;
        }
    }
}

