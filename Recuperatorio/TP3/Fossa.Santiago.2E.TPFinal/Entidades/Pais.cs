using System;
using System.Collections.Generic;

namespace Entidades
{
    public enum EContinente
    {
        Norteamerica, Sudamerica, Centroamerica, Europa, Africa, Asia, Oceania, Otros
    }

    public class Pais : IEstadisticas
    {
        string nombre;
        EContinente continente;
        long poblacionTotal;
        long infectados;
        long fallecidos;
        long vacunados;

        Pais()
        {

        }

        public Pais(string nombre, EContinente continente, long poblacionTotal, long infectados, long fallecidos, long vacunados)
        {
            this.Nombre = nombre;
            this.Continente = continente;
            this.PoblacionTotal = poblacionTotal;
            this.Infectados = infectados;
            this.Fallecidos = fallecidos;
            this.Vacunados = vacunados;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public EContinente Continente
        {
            get
            {
                return continente;
            }
            set
            {
                this.continente = value;
            }
        }

        /// <summary>
        /// Valida que la poblacion sea mayor de 10000
        /// </summary>
        public long PoblacionTotal
        {
            get
            {
                return poblacionTotal;
            }
            set
            {
                if (value >= 10000)
                {
                    this.poblacionTotal = value;
                }
                else
                {
                    throw new ValorNumericoExeption("La poblacion total debe ser mayor a 10.000 habitantes");
                }
            }
        }

        /// <summary>
        /// Valida que la centidad de infectados sea mayor a 0 y menor a la poblacion total
        /// </summary>
        public long Infectados
        {
            get
            {
                return infectados;
            }
            set
            {
                if(value>=0)
                {
                    if (value < this.poblacionTotal) 
                    {
                        this.infectados = value;
                    }
                    else
                    {
                        throw new DatoIncorrectoException("La cantidad de infectados no puede ser mayor que la poblacion total");
                    }
                }
                else
                {
                    throw new ValorNumericoExeption("La cantidad de infectados no puede ser negativa");
                }
            }
        }

        /// <summary>
        /// Valida que la cantidad de fallecidos sea mayor a 0 y menor a la cantidad de infectados
        /// </summary>
        public long Fallecidos
        {
            get
            {
                return fallecidos;
            }
            set
            {
                if (value >= 0)
                {
                    if (value < this.infectados)
                    {
                        this.fallecidos = value;
                    }
                    else
                    {
                        throw new DatoIncorrectoException("La cantidad de fallecidos no puede ser mayor que los infectados");
                    }
                }
                else
                {
                    throw new ValorNumericoExeption("La cantidad de fallecidos no puede ser negativa");
                }
            }
        }

        /// <summary>
        /// Valida que la cantidad de vacunados sea mayor a 0 y menor a la poblacion total
        /// </summary>
        public long Vacunados
        {
            get
            {
                return vacunados;
            }
            set
            {
                if (value >= 0)
                {
                    if (value < this.poblacionTotal)
                    {
                        this.vacunados = value;
                    }
                    else
                    {
                        throw new DatoIncorrectoException("La cantidad de vacunados no puede ser mayor que la poblacion total");
                    }
                }
                else
                {
                    throw new ValorNumericoExeption("La cantidad de vacunados no puede ser negativa");
                }

            }
        }

        /// <summary>
        /// Crea un nuevo pais, validando previamente los parametros de entrada
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="continente"></param>
        /// <param name="poblacionTotal"></param>
        /// <param name="infectados"></param>
        /// <param name="fallecidos"></param>
        /// <param name="vacunados"></param>
        /// <returns>Devuelve un nuevo pais o null si no se validaron los parametros</returns>
        public static Pais CrearNuevoPais(string nombre, string continente, string poblacionTotal, string infectados, string fallecidos, string vacunados)
        {
            Pais nuevoPais;

            if (Validaciones.ValidarSoloLetras(nombre) && Validaciones.ValidarLong(poblacionTotal) && Validaciones.ValidarLong(infectados) &&
                Validaciones.ValidarLong(fallecidos) && Validaciones.ValidarLong(vacunados))
            {
                string _nombre = nombre.DarFormatoNombre();
                EContinente _continente = ValidarContinente(continente);
                long _poblacion = long.Parse(poblacionTotal);
                long _infectados = long.Parse(infectados);
                long _fallecidos = long.Parse(fallecidos);
                long _vacunados = long.Parse(vacunados);

                nuevoPais = new Pais(_nombre, _continente, _poblacion, _infectados, _fallecidos, _vacunados);
            }
            else
            {
                nuevoPais = null;
            }

            return nuevoPais;
        }

        /// <summary>
        /// Valida un tipo EContinente a partir de un tipo string
        /// </summary>
        /// <param name="continente"></param>
        /// <returns></returns>
        public static EContinente ValidarContinente(string continente)
        {
            foreach(EContinente item in Enum.GetValues(typeof(EContinente)))
            {
                if(item.ToString()==continente)
                {
                    return item;
                }
  
            }

            return EContinente.Otros;
        }

        /// <summary>
        /// Calcula el porcentaje de infectados con respecto a la poblacion de un pais
        /// </summary>
        /// <returns></returns>
        public double PorcentajeInfectados()
        {
            double porcentaje = (double)this.infectados * 100 / (double)this.poblacionTotal;
            porcentaje = Math.Round((Double)porcentaje, 2);
            return porcentaje;
        }

        /// <summary>
        /// Calcula el porcentaje de fallecidos con respecto a los infectados de un pais
        /// </summary>
        /// <returns></returns>
        public double PorcentajeFallecidos()
        {
            double porcentaje = (double)this.fallecidos * 100 / (double)this.infectados;
            porcentaje = Math.Round((Double)porcentaje, 2);
            return porcentaje;
        }

        /// <summary>
        /// Calcula el porcentaje de vacunados con respecto a la poblacion de un pais
        /// </summary>
        /// <returns></returns>
        public double PorcentajeVacunados()
        {
            double porcentaje = (double)this.vacunados * 100 / (double)this.poblacionTotal;
            porcentaje = Math.Round((Double)porcentaje, 2);
            return porcentaje;
        }

        public string MostrarPais()
        {
            return $"{this.nombre} - Cont: {this.continente} - Pobl: {this.poblacionTotal} " +
                $"- Inf: {this.infectados} - Fall: {this.fallecidos} - Vac: {this.vacunados}";
        }

        /// <summary>
        /// Calcula la cantidad de infectados por millon de habitantes
        /// </summary>
        /// <returns></returns>
        public double CalcularInfectadosPorMillon()
        {
            double infectadosPorMillon = (double)this.infectados / this.poblacionTotal * 1000000;
            return Math.Round(infectadosPorMillon, 2);
        }

        /// <summary>
        /// Calcula la cantidad de fallecidos por millon de habitantes
        /// </summary>
        /// <returns></returns>
        public double CalcularFallecidosPorMillon()
        {
            double fallecidosPorMillon = (double)this.fallecidos / this.poblacionTotal * 1000000;
            return Math.Round(fallecidosPorMillon, 2);
        }

        /// <summary>
        /// Calcula la cantidad de vacunados por millon de habitantes
        /// </summary>
        /// <returns></returns>
        public double CalcularVacunadosPorMillon()
        {
            double vacunadosPorMillon = (double)this.vacunados / this.poblacionTotal * 1000000;
            return Math.Round(vacunadosPorMillon, 2);
        }


        /// <summary>
        /// Sobrecarga del == que valida si un pais ya se encuentra en una lista
        /// </summary>
        /// <param name="listaPaises"></param>
        /// <param name="pais"></param>
        /// <returns></returns>
        public static bool operator ==(List<Pais> listaPaises, Pais pais)
        {
            return listaPaises.Exists(p => p.Nombre.ToLower() == pais.Nombre.ToLower());
        }

        public static bool operator !=(List<Pais> listaPaises, Pais pais)
        {
            return !(listaPaises == pais);
        }

    }
}
