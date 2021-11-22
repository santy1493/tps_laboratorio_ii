using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoBorrarPais();

    public class Mundo : IEstadisticas
    {
        List<Pais> listaPaises;
        public event DelegadoBorrarPais paisBorrado;
       
        public Mundo()
        {
            this.listaPaises = new List<Pais>();
        }

        public List<Pais> ListaPaises
        {
            get
            {
                return this.listaPaises;
            }
            set
            {
                this.listaPaises = value;
            }
        }

        /// <summary>
        /// Agrega un nuevo pais en listaPaises, validando previamente que no se encuentre ese pais en la lista
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="continente"></param>
        /// <param name="poblacionTotal"></param>
        /// <param name="infectados"></param>
        /// <param name="fallecidos"></param>
        /// <param name="vacunados"></param>
        public void AltaPais(string nombre, string continente, string poblacionTotal, string infectados, string fallecidos, string vacunados)
        {
            Pais nuevoPais = Pais.CrearNuevoPais(nombre, continente, poblacionTotal, infectados, fallecidos, vacunados);

            if(!(nuevoPais is null))
            {
                if (this.ListaPaises != nuevoPais)
                {

                    this.ListaPaises.Add(nuevoPais);
                }
                else
                {
                    throw new PaisRepetidoException("El pais ya se encuentra en la lista");
                }
            }

        }

        /// <summary>
        /// Busca el nombre del pais en listaPaises y lo borra de la lista
        /// </summary>
        /// <param name="nombrePais"></param>
        /// <returns>Devuelve true si lo encontro, false si no estaba en la lista</returns>
        public bool EliminarPais(string nombrePais)
        {
            foreach (Pais p in this.ListaPaises)
            {
                if (p.Nombre.ToLower() == nombrePais.ToLower())
                {
                    this.ListaPaises.Remove(p);
                    if (this.listaPaises.Count < 1)
                    {
                        paisBorrado.Invoke();
                    }
                    return true;
                }
            }

            return false;
        }

        public bool BorrarLista()
        {
            if(!(this.listaPaises is null) && this.listaPaises.Count>0)
            {
                this.listaPaises.Clear();
                this.paisBorrado.Invoke();
                return true;
            }
            return false;
        }

        #region Estadisticas

        /// <summary>
        /// Suma la poblacion total de cada pais en listaPaises
        /// </summary>
        /// <returns></returns>
        public double CalcularPoblacionTotal()
        {
            double poblacionTotal = 0;

            listaPaises.ForEach((p) => poblacionTotal += p.PoblacionTotal);

            return poblacionTotal;
        }

        /// <summary>
        /// Suma la cantidad de infectados de cada pais en listaPaises
        /// </summary>
        /// <returns></returns>
        public double CalcularTotalInfectados()
        {
            double totalInfectados = 0;

            listaPaises.ForEach((p) => totalInfectados += p.Infectados);

            return totalInfectados;
        }

        /// <summary>
        /// Suma la cantidad de fallecidos de cada pais en listaPaises
        /// </summary>
        /// <returns></returns>
        public double CalcularTotalFallecidos()
        {
            double totalFallecidos = 0;

            listaPaises.ForEach((p) => totalFallecidos += p.Fallecidos);

            return totalFallecidos;
        }

        /// <summary>
        /// Suma la cantidad de vacunados de cada pais en listaPaises
        /// </summary>
        /// <returns></returns>
        public double CalcularTotalVacunados()
        {
            double totalVacunados = 0;

            listaPaises.ForEach((p) => totalVacunados += p.Vacunados);

            return totalVacunados;
        }

        /// <summary>
        /// Porcentaje del total de infectados con respecto a la poblacion total
        /// </summary>
        /// <returns></returns>
        public double PorcentajeInfectados()
        {
            double poblacionTotal = CalcularPoblacionTotal();
            double totalInfectados = CalcularTotalInfectados();
            double porcentajeInfectados = totalInfectados * 100 / poblacionTotal;

            porcentajeInfectados = Math.Round((Double)porcentajeInfectados, 2);

            return porcentajeInfectados;
        }

        /// <summary>
        /// Porcentaje del total de fallecidos con respecto al total de infectados
        /// </summary>
        /// <returns></returns>
        public double PorcentajeFallecidos()
        { 
            double totalInfectados = CalcularTotalInfectados();
            double totalFallecidos = CalcularTotalFallecidos();
            double porcentajeFallecidos = totalFallecidos * 100 / totalInfectados;

            porcentajeFallecidos = Math.Round((Double)porcentajeFallecidos, 2);

            return porcentajeFallecidos;
        }

        /// <summary>
        /// Porcentaje del total de vacunados con respecto a la poblacion total
        /// </summary>
        /// <returns></returns>
        public double PorcentajeVacunados()
        {
            double poblacionTotal = CalcularPoblacionTotal();
            double totalVacunados = CalcularTotalVacunados();
            double porcentajeVacunados = totalVacunados * 100 / poblacionTotal;

            porcentajeVacunados = Math.Round((Double)porcentajeVacunados, 2);

            return porcentajeVacunados;
        }

        /// <summary>
        /// Celcula el porcentaje de infectados de cada continente con respecto al total de infectados
        /// </summary>
        /// <returns>Devuelve un string con la lista de continentes y sus respectivos datos de infectados</returns>
        public string PorcentajeInfectadosContinente()
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<EContinente, long> listaContinentes = ListaInfectadosContinente();

            double totalInfectados = CalcularTotalInfectados();

            foreach (KeyValuePair<EContinente, long> item in listaContinentes)
            {
                double porcentaje = item.Value * 100 / totalInfectados;
                porcentaje = Math.Round((Double)porcentaje, 2);
                sb.AppendLine($"{item.Key}:  {item.Value} ({porcentaje}%)");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Crea una lista de tipo Dictianary donde la Key es el nombre del continente y el Value es la cantidad de infectados de ese continente
        /// </summary>
        /// <returns></returns>
        private Dictionary<EContinente, long> ListaInfectadosContinente()
        {
            Dictionary<EContinente, long> listaContinentes = new Dictionary<EContinente, long>();

            foreach (Pais p in this.listaPaises)
            {
                if (listaContinentes.ContainsKey(p.Continente))
                {
                    listaContinentes[p.Continente] += p.Infectados;
                }
                else
                {
                    listaContinentes.Add(p.Continente, p.Infectados);
                }
            }

            return listaContinentes;
        }

        /// <summary>
        /// Crea una lista de tipo Dictianary donde la Key es el nombre del continente y el Value es la poblacion total de ese continente
        /// </summary>
        /// <returns></returns>
        private Dictionary<EContinente, long> ListaPoblacionContinente()
        {
            Dictionary<EContinente, long> listaContinentes = new Dictionary<EContinente, long>();

            foreach (Pais p in this.listaPaises)
            {
                if (listaContinentes.ContainsKey(p.Continente))
                {
                    listaContinentes[p.Continente] += p.PoblacionTotal;
                }
                else
                {
                    listaContinentes.Add(p.Continente, p.PoblacionTotal);
                }
            }

            return listaContinentes;
        }

        /// <summary>
        /// Crea una lista de tipo Dictianary donde la Key es el nombre del continente y el Value es la cantidad de fallecidos de ese continente
        /// </summary>
        /// <returns></returns>
        private Dictionary<EContinente, long> ListaFallecidosContinente()
        {
            Dictionary<EContinente, long> listaContinentes = new Dictionary<EContinente, long>();

            foreach (Pais p in this.listaPaises)
            {
                if (listaContinentes.ContainsKey(p.Continente))
                {
                    listaContinentes[p.Continente] += p.Fallecidos;
                }
                else
                {
                    listaContinentes.Add(p.Continente, p.Fallecidos);
                }
            }

            return listaContinentes;
        }

        /// <summary>
        /// Crea una lista de tipo Dictianary donde la Key es el nombre del continente y el Value es la cantidad de vacunados de ese continente
        /// </summary>
        /// <returns></returns>
        private Dictionary<EContinente, long> ListaVacunadosContinente()
        {
            Dictionary<EContinente, long> listaContinentes = new Dictionary<EContinente, long>();

            foreach (Pais p in this.listaPaises)
            {
                if (listaContinentes.ContainsKey(p.Continente))
                {
                    listaContinentes[p.Continente] += p.Vacunados;
                }
                else
                {
                    listaContinentes.Add(p.Continente, p.Vacunados);
                }
            }

            return listaContinentes;
        }

        /// <summary>
        /// Crea una lista de tipo Dictianary donde la Key es el nombre del continente y el Value es la cantidad de infectados de ese continente
        /// </summary>
        /// <returns></returns>
        private double PoblacionDeUnContinente(EContinente continente)
        {
            Dictionary<EContinente, long> listaContinentes = ListaPoblacionContinente();

            foreach (KeyValuePair<EContinente, long> item in listaContinentes)
            {
                if (item.Key == continente)
                {
                    return item.Value;
                }
            }

            return 0;
        }

        /// <summary>
        /// Busca en la lista de tipo Dictiary un continente en concreto y devuelve la cantidad de vacunados de ese continente
        /// </summary>
        /// <param name="continente"></param>
        /// <returns></returns>
        private long VacunadosDeUnContinente(EContinente continente)
        {
            Dictionary<EContinente, long> listaContinentes = ListaVacunadosContinente();

            foreach (KeyValuePair<EContinente, long> item in listaContinentes)
            {
                if (item.Key == continente)
                {
                    return item.Value;
                }
            }

            return 0;
        }

        /// <summary>
        /// Busca en la lista de tipo Dictiary un continente en concreto y devuelve la cantidad de infectados de ese continente
        /// </summary>
        /// <param name="continente"></param>
        /// <returns></returns>
        private long InfectadosDeUnContinente(EContinente continente)
        {
            Dictionary<EContinente, long> listaContinentes = ListaInfectadosContinente();

            foreach (KeyValuePair<EContinente, long> item in listaContinentes)
            {
                if (item.Key == continente)
                {
                    return item.Value;
                }
            }

            return 0;
        }

        /// <summary>
        /// Busca en la lista de tipo Dictiary un continente en concreto y devuelve la cantidad de fallecidos de ese continente
        /// </summary>
        /// <param name="continente"></param>
        /// <returns></returns>
        private long FallecidosDeUnContinente(EContinente continente)
        {
            Dictionary<EContinente, long> listaContinentes = ListaFallecidosContinente();

            foreach (KeyValuePair<EContinente, long> item in listaContinentes)
            {
                if (item.Key == continente)
                {
                    return item.Value;
                }
            }

            return 0;
        }
        
        /// <summary>
        /// Delvuelve en un string los datos de un continente (poblacion total, infectados, fallecidos y vacunados).
        /// </summary>
        /// <param name="_continente"></param>
        /// <returns></returns>
        public string ImprimirDatosPorContinente(string _continente)
        {
            StringBuilder sb = new StringBuilder();

            EContinente continente = Pais.ValidarContinente(_continente);

            double poblacion = PoblacionDeUnContinente(continente);
            long infectados = InfectadosDeUnContinente(continente);
            long fallecidos = FallecidosDeUnContinente(continente);
            long vacunados = VacunadosDeUnContinente(continente);

            double porcentajeInfectados = infectados * 100 / poblacion;
            porcentajeInfectados = Math.Round((Double)porcentajeInfectados, 2);
            double porcentajeFallecidos = fallecidos * 100 / (double)infectados;
            porcentajeFallecidos = Math.Round((Double)porcentajeFallecidos, 2);
            double porcentajeVacunados = vacunados * 100 / poblacion;
            porcentajeVacunados = Math.Round((Double)porcentajeVacunados, 2);

            sb.AppendLine($"Poblacion total: {poblacion}");
            sb.AppendLine($"Infectados: {infectados} ({porcentajeInfectados}%)");
            sb.AppendLine($"Fallecidos: {fallecidos} ({porcentajeFallecidos}%)");
            sb.AppendLine($"Vacunados: {vacunados} ({porcentajeVacunados}%)");

            return sb.ToString();


        }

        /// <summary>
        /// Devuelve un string con los datos totales de todo el mundo
        /// </summary>
        /// <returns></returns>
        public string MostrarEstadisticasMundo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Poblacion Total: {this.CalcularPoblacionTotal()} personas");
            sb.AppendLine($"Cantidad de infectados: {this.CalcularTotalInfectados()} ({this.PorcentajeInfectados()}% de la poblacion)");
            sb.AppendLine($"Cantidad de fallecidos: {this.CalcularTotalFallecidos()} ({this.PorcentajeFallecidos()}% de los infectados)");
            sb.AppendLine($"Cantidad de vacunados: {this.CalcularTotalVacunados()} ({this.PorcentajeVacunados()}% de la poblacion)");

            return sb.ToString();
        }

        /// <summary>
        /// Filtra los diez paises con mas cantidad de infectados
        /// </summary>
        /// <returns></returns>
        public List<Pais> FiltrarDiezMasCantidadInfectados()
        {
            List<Pais> listaPaises = this.ListaPaises.OrderByDescending(p => p.Infectados).ToList();
            return listaPaises.GetRange(0, 10);
        }

        /// <summary>
        /// Filtra los diez paises con mas cantidad de fallecidos
        /// </summary>
        /// <returns></returns>
        public List<Pais> FiltrarDiezMasCantidadFallecidos()
        {
            List<Pais> listaPaises = this.ListaPaises.OrderByDescending(p => p.Fallecidos).ToList();
            return listaPaises.GetRange(0, 10);
        }

        /// <summary>
        /// Filtra los diez paises con menos porcentaje de fallecidos 
        /// </summary>
        /// <returns></returns>
        public List<Pais> FiltrarDiezMenosPorcentajeFallecidos()
        {
            List<Pais> listaPaises = this.ListaPaises.OrderBy(p => p.PorcentajeFallecidos()).ToList();
            return listaPaises.GetRange(0, 10);
        }

        /// <summary>
        /// Filtra los paises que son del continente recibido por parametro
        /// </summary>
        /// <param name="_continente"></param>
        /// <returns></returns>
        public List<Pais> FiltrarPorContinente(string _continente)
        {
            EContinente continente = Pais.ValidarContinente(_continente);

            List<Pais> listaPaises = this.ListaPaises.FindAll(p => p.Continente == continente);
            return listaPaises;
        }


        /// <summary>
        /// Filtra los diez paises con menos porcentaje de fallecidos 
        /// </summary>
        /// <returns></returns>
        public List<Pais> FiltrarDiezMasPorcentajeVacunados()
        {
            List<Pais> listaPaises = this.ListaPaises.OrderByDescending(p => p.PorcentajeVacunados()).ToList();
            return listaPaises.GetRange(0, 10);
        }

        #endregion

    }
}
