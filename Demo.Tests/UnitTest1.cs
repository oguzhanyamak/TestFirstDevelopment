using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Demo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void bir_elemanli_liste_birerli_gruplanmak_istediğinde_grup_sayisi_bir_olmalidir()
        {
            var olcumler = new List<Olcum>()
            {
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                }
            };
            var gruplayici = new Gruplayici(1);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(1, gruplar.Count);
        }

        [TestMethod]
        public void alti_elemanli_liste_ikiserli_gruplanmak_istediğinde_grup_sayisi_uc_olmalidir()
        {
            var olcumler = new List<Olcum>()
            {
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                }
            };
            var gruplayici = new Gruplayici(2);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(3, gruplar.Count);
        }
    }
}
