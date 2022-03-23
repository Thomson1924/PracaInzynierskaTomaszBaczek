using PracaInżynierskaTomaszBaczek.Interfaces;
using PracaInżynierskaTomaszBaczek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using static PracaInżynierskaTomaszBaczek.Models.Hill;

namespace PracaInżynierskaTomaszBaczek.Services
{
    public class HillService : IHillService
    {
        public async Task<string> CreateHill(UserInputModel model)
        {
            Hill hill = new Hill();
            hill.location = new Location();
            hill.weather = new Weather();
            hill.inrun = new Inrun();
            hill.inrun.profile = new Inrun.InrunProfile();
            hill.inrun.track = new Inrun.Track();
            hill.inrun.guardrail = new Inrun.Guardrail();
            hill.inrun.startgate = new Inrun.Startgate();
            hill.inrun.startbanner = new Inrun.Startbanner();
            hill.inrun.frame = new Inrun.Frame();
            hill.inrun.flag = new Inrun.Flag();
            hill.inrun.twigs = new Inrun.Twigs();
            hill.dhill = new Dhill();
            hill.dhill.profile = new Dhill.DhillProfile();
            hill.dhill.fence = new Dhill.Fence();
            hill.dhill.judgetower = new Dhill.Judgetower();
            hill.dhill.windflags = new Dhill.Windflags();
            hill.dhill.measurers = new Dhill.Measurers();
            hill.dhill.label = new Dhill.Label();
            hill.dhill.plastic = new Dhill.Plastic();
            hill.dhill.lines = new Dhill.Lines();
            hill.dhill.numbers = new Dhill.Numbers();
            hill.dhill.lights = new Dhill.Lights();
            hill.terrain = new Terrain();
            hill.terrain.profile = new Terrain.TerrainProfile();
            hill.terrain.trees = new Terrain.Trees();
            hill.terrain.blocks = new Terrain.Blocks();
            hill.terrain.houses = new Terrain.Houses();
            hill.terrain.audience = new Terrain.Audience();
            hill.railings = new List<Railing>();
            hill.railings.Add(new Railing
            {
                t = @"Textures\railing-glass.png",
                y = "-2.1",
                c = "0xf2e5c7",
                m = @"Materials\material1.xml",
                h = "2.0",
                refx1 = "inrun",
                refx2 = "dhill",
                w = "4.0"
            });
            hill.railings.Add(new Railing
            {
                refx1 = "inrun",
                refx2 = "dhill",
                type = "glass",
                h = "0.4",
                w = "0.1",
                z1 = "2",
                z2 = "2",
                t = @"Textures\railing-glass.png",
                m = @"Materials\window.xml",
                c = "0xffffffff",
                t3 = @"Textures\railing-glass-cut.png",
                m3 = @"Materials\window.xml",
                c3 = "0xffffffff",
                t6 = @"Textures\railing-glass-cut.png",
                m6 = @"Materials\window.xml",
                c6 = "0xffffffff"
            });
            hill.railings.Add(new Railing
            {
                refx1 = "inrun",
                refx2 = "dhill",
                guard = "false",
                type = "glass",
                h = "0.4",
                w = "0.1",
                z1 = "-2",
                z2 = "-2",
                t = @"Textures\railing-glass.png",
                m = @"Materials\window.xml",
                c = "0xffffffff",
                t3 = @"Textures\railing-glass-cut.png",
                m3 = @"Materials\window.xml",
                c3 = "0xffffffff",
                t6 = @"Textures\railing-glass-cut.png",
                m6 = @"Materials\window.xml",
                c6 = "0xffffffff"
            });

            hill.stairs = new List<Stairs>();
            hill.stairs.Add(new Stairs { });
            hill.stairs.Add(new Stairs
            {
                lz = "-1",
                rz = "-2",
            });

            hill.pillar = new Pillar();

            hill.profile = new List<Profile>();
            hill.profile.Add(new Profile
            {
                start = new Profile.Start(),
                line = new Profile.Line(),
            });
            hill.profile.Add(new Profile
            {
                id = "inrun-left",
                start = new Profile.Start { y = "1.0" },
                line = new Profile.Line { y = "1.0" }

            });
            string fullName = $"{model.HillName}-HS{model.HillSize}-{model.CountryCode}.xml";
            var scale = ScaleCounter(model.HillSize.ToString(), hill.dhill.profile.hs);
            var a = BasicEditor(hill, scale, Convert.ToDouble(model.HillSize));
            HillNameChange(hill, model.HillName, model.CountryCode);
            Save(fullName, a);
            return fullName;
        }

        private double ScaleCounter(string userhillsize, string hillsize)
        {
            var scale = 1.0;
            if (userhillsize != "")
            {
                scale = Convert.ToDouble(userhillsize) / Convert.ToDouble(hillsize);
            }
            return scale;
        }

        private void Save(string fileName, Hill hill)
        {
            XmlSerializerNamespaces emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            XmlSerializer serializer = new XmlSerializer(typeof(Hill), new XmlRootAttribute("hill"));

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,

            };

            using (XmlWriter xmlWriter = XmlWriter.Create(fileName, settings))
            {
                serializer.Serialize(xmlWriter, hill, emptyNamespaces);
            }
        }
        private void HillNameChange(Hill hill, string name, string country)
        {
            hill.inrun.startbanner.text = name.ToUpper();
            hill.dhill.label.text = name.ToUpper();
            hill.inrun.flag.tf = $@"Textures\flag-{country.ToLower()}.png";
        }

        private Hill BasicEditor(Hill hill, double scale, double userhillsize)
        {
            //e * ((-0.001 * userhillsize) + 1.15)
            //t  * 0.65
            // gates location point - 16,39


            //inrun profile
            hill.inrun.profile.e = Math.Round((Convert.ToDouble(hill.inrun.profile.e) * ((-0.0009 * userhillsize) + 1.101) * scale), 2).ToString().Replace(',', '.');
            hill.inrun.profile.es = Math.Round((Convert.ToDouble(hill.inrun.profile.e.ToString().Replace('.', ',')) * 0.1639), 2).ToString().Replace(',', '.');
            hill.inrun.profile.t = Math.Round((Convert.ToDouble(hill.inrun.profile.e.ToString().Replace('.', ',')) * 0.0588), 2).ToString().Replace(',', '.');
            hill.inrun.profile.r1 = Math.Round((Convert.ToDouble(hill.inrun.profile.r1) * scale), 2).ToString().Replace(',', '.');
            hill.inrun.profile.s = Math.Round((Convert.ToDouble(hill.inrun.profile.s) * 0.5 * scale), 2).ToString().Replace(',', '.');
            //hill.inrun.profile.alpha = Math.Round(1470 / (Convert.ToDouble(hill.inrun.profile.e.ToString().Replace('.', ','))+50), 2).ToString().Replace(',', '.');
            hill.inrun.profile.b1 = Math.Round((Convert.ToDouble(hill.inrun.profile.b1) * scale), 2).ToString().Replace(',', '.');
            hill.inrun.profile.z0 = Math.Round((Convert.ToDouble(hill.inrun.profile.z0) * scale), 2).ToString().Replace(',', '.');
            hill.inrun.profile.l = Math.Round((Convert.ToDouble(hill.inrun.profile.l) * scale), 2).ToString().Replace(',', '.');
            hill.inrun.profile.f = Math.Round((Convert.ToDouble(hill.inrun.profile.f) * scale), 2).ToString().Replace(',', '.');

            //frame
            hill.inrun.frame.bh = Math.Round((Convert.ToDouble(hill.inrun.frame.bh) * scale), 2).ToString().Replace(',', '.');

            //downhill profile
            hill.dhill.profile.h = Math.Round((Convert.ToDouble(hill.dhill.profile.h) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.n = Math.Round((Convert.ToDouble(hill.dhill.profile.n) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.l1 = Math.Round((Convert.ToDouble(hill.dhill.profile.l1) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.l2 = Math.Round((Convert.ToDouble(hill.dhill.profile.l2) * scale), 2).ToString().Replace(',', '.');
            //hill.dhill.profile.a = Math.Round((Convert.ToDouble(hill.dhill.profile.a) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.rl = Math.Round((Convert.ToDouble(hill.dhill.profile.rl) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.r2 = Math.Round((Convert.ToDouble(hill.dhill.profile.r2) * 1.2 * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.b0 = Math.Round((Convert.ToDouble(hill.dhill.profile.b0) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.bk = Math.Round((Convert.ToDouble(hill.dhill.profile.bk) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.ba = Math.Round((Convert.ToDouble(hill.dhill.profile.ba) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.hr = Math.Round((Convert.ToDouble(hill.dhill.profile.hr) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.nr = Math.Round((Convert.ToDouble(hill.dhill.profile.nr) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.ar = Math.Round((Convert.ToDouble(hill.dhill.profile.ar) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.profile.k = Math.Round((Convert.ToDouble(hill.dhill.profile.k) * scale), 0).ToString().Replace(',', '.');
            hill.dhill.profile.hs = Math.Round((Convert.ToDouble(hill.dhill.profile.hs) * scale), 0).ToString().Replace(',', '.');

            //startgate
            hill.inrun.startgate.max = Math.Round((Convert.ToDouble(hill.inrun.startgate.max) * 0.7 * scale), 0).ToString().Replace(',', '.');
            hill.inrun.startgate.Default = Math.Round((Convert.ToDouble(hill.inrun.startgate.Default) * 0.7 * scale), 0).ToString().Replace(',', '.');

            //lights
            hill.dhill.lights.x0 = Math.Round((Convert.ToDouble(hill.dhill.lights.x0) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.lights.x1 = Math.Round((Convert.ToDouble(hill.dhill.lights.x1) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.lights.d = Math.Round((Convert.ToDouble(hill.dhill.lights.d) * 0.5 * scale), 2).ToString().Replace(',', '.');

            //windflags
            hill.dhill.windflags.h = Math.Round((Convert.ToDouble(hill.dhill.windflags.h) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.windflags.d = Math.Round((Convert.ToDouble(hill.dhill.windflags.d) * scale), 2).ToString().Replace(',', '.');
            hill.dhill.windflags.l = Math.Round((Convert.ToDouble(hill.dhill.windflags.l) * scale), 2).ToString().Replace(',', '.');

            //label
            hill.dhill.label.summerd = Math.Round((Convert.ToDouble(hill.dhill.label.summerd) * scale), 0).ToString().Replace(',', '.');
            hill.dhill.label.winterd = Math.Round((Convert.ToDouble(hill.dhill.label.winterd) * scale), 0).ToString().Replace(',', '.');
            hill.dhill.label.textsize = Math.Round((Convert.ToDouble(hill.dhill.label.textsize) * scale), 2).ToString().Replace(',', '.');

            //lines
            hill.dhill.lines.summermin = Math.Round((Convert.ToDouble(hill.dhill.lines.summermin) * scale), 0).ToString().Replace(',', '.');
            hill.dhill.lines.summermax = Math.Round((Convert.ToDouble(hill.dhill.lines.summermax) * scale), 0).ToString().Replace(',', '.');
            hill.dhill.lines.wintermin = Math.Round((Convert.ToDouble(hill.dhill.lines.wintermin) * scale), 0).ToString().Replace(',', '.');
            hill.dhill.lines.wintermax = Math.Round((Convert.ToDouble(hill.dhill.lines.wintermax) * scale), 0).ToString().Replace(',', '.');

            //numbers
            hill.dhill.numbers.min = Math.Round((Convert.ToDouble(hill.dhill.numbers.min) * scale), 0).ToString().Replace(',', '.');
            hill.dhill.numbers.max = Math.Round((Convert.ToDouble(hill.dhill.numbers.max) * scale), 0).ToString().Replace(',', '.');

            //stairs
            hill.stairs.ElementAt(0).x2 = Math.Round((Convert.ToDouble(hill.stairs.ElementAt(0).x2) * scale), 0).ToString().Replace(',', '.');
            hill.stairs.ElementAt(1).x2 = Math.Round((Convert.ToDouble(hill.stairs.ElementAt(1).x2) * scale), 0).ToString().Replace(',', '.');

            //audience
            hill.terrain.audience.count = Math.Round((Convert.ToDouble(hill.terrain.audience.count) * scale), 0).ToString().Replace(',', '.');
            hill.terrain.audience.d = Math.Round((Convert.ToDouble(hill.terrain.audience.d) * scale), 0).ToString().Replace(',', '.');
            hill.terrain.audience.x0 = Math.Round((Convert.ToDouble(hill.terrain.audience.x0) * scale), 1).ToString().Replace(',', '.');
            return hill;
        }
    }
}
