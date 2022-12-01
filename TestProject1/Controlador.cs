using Calidad20222.web.Controllers;
using Calidad20222.web.Helper;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Controlador
    {
        PokerService pokerService;

        [Test]
        public void TestCartaMayor1()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 1,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 13,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 3,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 4,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("CARTA MAYOR", result);
        }

        [Test]
        public void TestCartaDoble2()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 1,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 12,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 5,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 1,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE", result);
        }

        [Test]
        public void TestCartaDoblePareja3()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 1,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 12,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 5,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 1,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE PAREJA", result);
        }

        [Test]
        public void TestCartaTrio4()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 11,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 11,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 3,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 11,
                    Palo = "CORAZON"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("TRIO", result);
        }

        [Test]
        public void TestCartaEscalera5()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 7,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 3,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 4,
                    Palo = "CORAZON"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA", result);
        }

        [Test]
        public void TestCartaColor6()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 8,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 1,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 11,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 5,
                    Palo = "TREBOL"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("COLOR", result);
        }

        [Test]
        public void TestCartaFull7()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 8,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 6,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 8,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 8,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("FULL", result);
        }

        [Test]
        public void TestCartaPoker8()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 8,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 6,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 6,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 6,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("POKER", result);
        }

        [Test]
        public void TestCartaEscaleraColor9()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 8,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 9,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 7,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 5,
                    Palo = "TREBOL"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA COLOR", result);
        }

        [Test]
        public void TestCartaEscaleraReal10()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 1,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 12,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 10,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 11,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 13,
                    Palo = "TREBOL"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA REAL", result);
        }

        [Test]
        public void TestCartaMayor11()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 10,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 8,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 3,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 4,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("CARTA MAYOR", result);
        }

        [Test]
        public void TestCartaDoble12()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 12,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 6,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 1,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE", result);
        }

        [Test]
        public void TestCartaDoblePareja13()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 1,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 5,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 6,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 1,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE PAREJA", result);
        }

        [Test]
        public void TestCartaTrio14()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 5,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 5,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 3,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 11,
                    Palo = "CORAZON"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("TRIO", result);
        }

        [Test]
        public void TestCartaEscalera15()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 1,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 5,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 2,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 3,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 4,
                    Palo = "CORAZON"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA", result);
        }

        [Test]
        public void TestCartaColor16()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 6,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 8,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 13,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 11,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 7,
                    Palo = "COCO"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("COLOR", result);
        }

        [Test]
        public void TestCartaFull17()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 12,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 8,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 12,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 8,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 8,
                    Palo = "CORAZON"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("FULL", result);
        }

        [Test]
        public void TestCartaPoker18()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 7,
                    Palo = "CORAZON"
                },
                new Carta{
                    Numero = 7,
                    Palo = "TREBOL"
                },
                new Carta{
                    Numero = 7,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 4,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 7,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("POKER", result);
        }

        [Test]
        public void TestCartaEscaleraColor19()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 7,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 8,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 9,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 11,
                    Palo = "ESPADA"
                },
                new Carta{
                    Numero = 10,
                    Palo = "ESPADA"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA COLOR", result);
        }

        [Test]
        public void TestCartaEscaleraReal20()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta{
                    Numero = 1,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 12,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 10,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 11,
                    Palo = "COCO"
                },
                new Carta{
                    Numero = 13,
                    Palo = "COCO"
                },
            };

            pokerService = new PokerService();
            var result = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA REAL", result);
        }
    }
}
