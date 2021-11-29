using System;
using System.Collections.Generic;
using System.IO;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Mundo mundo = new Mundo();

            mundo.AltaPais("estados unidos", "Norteamerica", "333659530", "46949943", "761354", "193487135");
            mundo.AltaPais("india", "Asia", "1398494658", "34426036", "463245", "367698745");
            mundo.AltaPais("brasil", "Sudamerica", "214619177", "21940950", "610935", "126202217");
            mundo.AltaPais("reino unido", "Europa", "68372226", "9524971", "142835", "45985795");
            mundo.AltaPais("rusia", "Europa", "146019815", "9031851", "254167", "50991092");
            mundo.AltaPais("turquia", "Asia", "85575739", "8386542", "73342", "49594716");
            mundo.AltaPais("francia", "Europa", "65470493", "7275149", "118137", "46312482");
            mundo.AltaPais("iran", "Asia", "85457576", "6031575", "128042", "42183468");
            mundo.AltaPais("argentina", "Sudamerica", "45761013", "5304059", "116222", "27201986");
            mundo.AltaPais("españa", "Europa", "46779479", "5047156", "87673", "37448743");
            mundo.AltaPais("colombia", "Sudamerica", "51621938", "5026822", "127721", "22626221");
            mundo.AltaPais("alemania", "Europa", "84149279", "5009388", "98159", "56141195");
            mundo.AltaPais("italia", "Europa", "60340543", "4852496", "132739", "43772698");
            mundo.AltaPais("indonesia", "Asia", "277465027", "4250516", "143644", "83418086");
            mundo.AltaPais("mexico", "Norteamerica", "130778720", "3841661", "290872", "62881897");

            Console.WriteLine("Paises:\n");

            foreach (Pais p in mundo.ListaPaises)
            {
                Console.WriteLine(p.MostrarPais());
            }

            Console.WriteLine("\nEstadisticas del mundo:\n");
            Console.WriteLine(mundo.MostrarEstadisticasMundo());

            Console.WriteLine("\nMostrar datos de Europa:\n");
            Console.WriteLine(mundo.ImprimirDatosPorContinente("Europa"));

            Console.WriteLine("\nEliminar Argentina de la lista:\n");
            Console.WriteLine($"Se elimino el pais? {mundo.EliminarPais("argentina")}\n");

            foreach (Pais p in mundo.ListaPaises)
            {
                Console.WriteLine(p.MostrarPais());
            }

            Console.WriteLine($"\nMostrar estadisticas de {mundo.ListaPaises[4].Nombre}\n");
            Console.WriteLine($"Poblacion: {mundo.ListaPaises[4].PoblacionTotal}");
            Console.WriteLine($"Infectados: {mundo.ListaPaises[4].Infectados} ({mundo.ListaPaises[4].PorcentajeInfectados()})%");
            Console.WriteLine($"Infectados: {mundo.ListaPaises[4].Fallecidos} ({mundo.ListaPaises[4].PorcentajeFallecidos()})%");
            Console.WriteLine($"Infectados: {mundo.ListaPaises[4].Vacunados} ({mundo.ListaPaises[4].PorcentajeVacunados()})%");
        }
    }
}
