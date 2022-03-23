using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PracaInżynierskaTomaszBaczek.Models
{
    public class Hill
    {

        [XmlAttribute]
        public string version { get; set; } = "DSJ4-1.7.0";
        public Location location { get; set; }
        public Weather weather { get; set; }
        public Inrun inrun { get; set; }
        public Dhill dhill { get; set; }
        [XmlElement(ElementName = "profile")]
        public List<Profile> profile { get; set; }
        public Terrain terrain { get; set; }
        [XmlElement(ElementName = "stairs")]
        public List<Stairs> stairs { get; set; }
        [XmlElement("railing")]
        public List<Railing> railings { get; set; }

        public Pillar pillar { get; set; }


        public class Location
        {
            [XmlAttribute]
            public string latitude { get; set; } = "49.1976";
            [XmlAttribute]
            public string longitude { get; set; } = "20.0712";
            [XmlAttribute]
            public string orientation { get; set; } = "245.0";
            [XmlAttribute]
            public string timezone { get; set; } = "2.0";
            [XmlAttribute]
            public string altitude { get; set; } = "1300.0";
        }

        public class Weather
        {
            [XmlAttribute]
            public string pollution { get; set; } = "0.0";
            [XmlAttribute]
            public string firstsnow { get; set; } = "300.0";
            [XmlAttribute]
            public string lastsnow { get; set; } = "90.0";
            [XmlAttribute]
            public string maxsnow { get; set; } = "1.5";
            [XmlAttribute]
            public string precipitationprobability { get; set; } = "0.1";
            [XmlAttribute]
            public string fogprobability { get; set; } = "0.1";
        }
        public class Inrun
        {
            public InrunProfile profile { get; set; }
            public Track track { get; set; }
            public Guardrail guardrail { get; set; }
            public Startgate startgate { get; set; }
            public Startbanner startbanner { get; set; }
            public Frame frame { get; set; }
            public Flag flag { get; set; }
            public Twigs twigs { get; set; }
            public class InrunProfile
            {
                [XmlAttribute]
                public string e { get; set; } = "91,5";
                [XmlAttribute]
                public string es { get; set; } = "15,0";
                [XmlAttribute]
                public string t { get; set; } = "6.43";
                [XmlAttribute]
                public string gamma { get; set; } = "40.5";
                [XmlAttribute]
                public string alpha { get; set; } = "5.5";
                [XmlAttribute]
                public string r1 { get; set; } = "105,0";
                [XmlAttribute]
                public string s { get; set; } = "2,5";
                [XmlAttribute]
                public string b1 { get; set; } = "2,0";
                [XmlAttribute]
                public string z0 { get; set; } = "0,0";
                [XmlAttribute]
                public string l { get; set; } = "6,5";
                [XmlAttribute]
                public string f { get; set; } = "2,0";
            }
            public class Track
            {
                [XmlAttribute]
                public string type { get; set; } = "ceramic";
                [XmlAttribute]
                public string snow { get; set; } = "false";
            }
            public class Guardrail
            {
                [XmlAttribute]
                public string z1 { get; set; } = "-1.0";
                [XmlAttribute]
                public string z2 { get; set; } = "1.0";
                [XmlAttribute]
                public string x { get; set; } = "30";
            }
            public class Startgate
            {
                [XmlAttribute(AttributeName = "default")]
                public string Default { get; set; } = "8";
                [XmlAttribute]
                public string max { get; set; } = "30";
                [XmlAttribute]
                public string step { get; set; } = "0.35";
                [XmlAttribute]
                public string wind { get; set; } = "2.4";
                [XmlAttribute]
                public string z1 { get; set; } = "-1.0";
                [XmlAttribute]
                public string z2 { get; set; } = "1.0";
                [XmlAttribute]
                public string pz1 { get; set; } = "-0.8";
                [XmlAttribute]
                public string pz2 { get; set; } = "0.8";
                [XmlAttribute]
                public string t1 { get; set; } = @"Textures\metal.png";
                [XmlAttribute]
                public string m1 { get; set; } = @"Materials\material1.xml";
                [XmlAttribute]
                public string c1 { get; set; } = "0xaaaaaa";
                [XmlAttribute]
                public string t2 { get; set; } = @"Textures\metal.png";
                [XmlAttribute]
                public string m2 { get; set; } = @"Materials\material1.xml";
                [XmlAttribute]
                public string c2 { get; set; } = "0x999999";
                [XmlAttribute]
                public string t3 { get; set; } = @"Textures\metal.png";
                [XmlAttribute]
                public string c3 { get; set; } = "0x858585";
            }
            public class Startbanner
            {
                [XmlAttribute]
                public string z { get; set; } = "0";
                [XmlAttribute]
                public string text { get; set; } = "DEFAULT";
                [XmlAttribute]
                public string textsize { get; set; } = "0.1";
            }
            public class Frame
            {
                [XmlAttribute]
                public string bh { get; set; } = "2,0";
                [XmlAttribute]
                public string snow { get; set; } = "true";
                [XmlAttribute]
                public string t { get; set; } = @"Textures\concrete5.png";
                [XmlAttribute]
                public string m { get; set; } = @"Materials\material1.xml";
                [XmlAttribute]
                public string c0 { get; set; } = "0x97a594";
                [XmlAttribute]
                public string c1 { get; set; } = "0xB2ABA0";
                [XmlAttribute]
                public string c { get; set; } = "0x504941";
                [XmlAttribute]
                public string c2 { get; set; } = "0xB2ABA0";
            }
            public class Flag
            {
                [XmlAttribute]
                public string x { get; set; } = "12.5";
                [XmlAttribute]
                public string z { get; set; } = "4.55";
                [XmlAttribute]
                public string hf { get; set; } = "1.4";
                [XmlAttribute]
                public string pf { get; set; } = "1.6153";
                [XmlAttribute]
                public string hp { get; set; } = "15.0";
                [XmlAttribute]
                public string rb { get; set; } = "0.07";
                [XmlAttribute]
                public string rt { get; set; } = "0.05";
                [XmlAttribute]
                public string tf { get; set; } = @"Textures\flag-pol.png";
                [XmlAttribute]
                public string mf { get; set; } = @"Materials\flag.xml";
                [XmlAttribute]
                public string tp { get; set; } = @"Textures\wood1.png";
                [XmlAttribute]
                public string mp { get; set; } = @"Materials\material1.xml";
                [XmlAttribute]
                public string cp { get; set; } = "0xffffff";
            }
            public class Twigs
            {
                [XmlAttribute]
                public string lz { get; set; } = "1.0";
                [XmlAttribute]
                public string rz { get; set; } = "-1.0";
            }
        }
        public class Dhill
        {
            public DhillProfile profile { get; set; }
            public Fence fence { get; set; }
            public Judgetower judgetower { get; set; }
            public Lights lights { get; set; }
            public Windflags windflags { get; set; }
            public Measurers measurers { get; set; }
            public Label label { get; set; }
            public Plastic plastic { get; set; }
            public Lines lines { get; set; }
            public Numbers numbers { get; set; }

            public class DhillProfile
            {
                [XmlAttribute]
                public string alpha { get; set; } = "6.28";
                [XmlAttribute]
                public string h { get; set; } = "62,93";
                [XmlAttribute]
                public string n { get; set; } = "107,41";
                [XmlAttribute]
                public string l1 { get; set; } = "16,04";
                [XmlAttribute]
                public string l2 { get; set; } = "13,38";
                [XmlAttribute]
                public string a { get; set; } = "87,5";
                [XmlAttribute(AttributeName = "beta-p")]
                public string betap { get; set; } = "37.7";
                [XmlAttribute]
                public string beta { get; set; } = "34.7";
                [XmlAttribute(AttributeName = "beta-l")]
                public string betal { get; set; } = "32.2";
                [XmlAttribute]
                public string rl { get; set; } = "306,15";
                [XmlAttribute]
                public string r2 { get; set; } = "73,22";
                [XmlAttribute]
                public string b0 { get; set; } = "9,5";
                [XmlAttribute]
                public string bk { get; set; } = "23,37";
                [XmlAttribute]
                public string ba { get; set; } = "25";
                [XmlAttribute]
                public string hr { get; set; } = "10";
                [XmlAttribute]
                public string nr { get; set; } = "60";
                [XmlAttribute]
                public string ar { get; set; } = "10";
                [XmlAttribute]
                public string k { get; set; } = "120";
                [XmlAttribute]
                public string hs { get; set; } = "140";
            }
            public class Fence
            {
                [XmlAttribute]
                public string t { get; set; } = @"Textures\fenceback.png";
                [XmlAttribute]
                public string m { get; set; } = @"Materials\material1.xml";
                [XmlAttribute]
                public string c { get; set; } = "0xffffff";

            }
            public class Judgetower
            {
                [XmlAttribute]
                public string d { get; set; } = "68.5";
                [XmlAttribute]
                public string q { get; set; } = "25.4";
                [XmlAttribute]
                public string h { get; set; } = "+4";
                [XmlAttribute]
                public string t1 { get; set; } = @"Textures\wood3.png";
                [XmlAttribute]
                public string m1 { get; set; } = @"Materials\wood.xml";
                [XmlAttribute]
                public string c1 { get; set; } = "0x78554e";
                [XmlAttribute]
                public string t2 { get; set; } = @"Textures\wood3.png";
                [XmlAttribute]
                public string m2 { get; set; } = @"Materials\wood.xml";
                [XmlAttribute]
                public string c2 { get; set; } = "0x959183";
            }
            public class Lights
            {
                [XmlAttribute]
                public string x0 { get; set; } = "-100";
                [XmlAttribute]
                public string x1 { get; set; } = "210";
                [XmlAttribute]
                public string side { get; set; } = "left";
                [XmlAttribute]
                public string step { get; set; } = "60";
                [XmlAttribute]
                public string size { get; set; } = "3";
                [XmlAttribute]
                public string h { get; set; } = "30";
                [XmlAttribute]
                public string d { get; set; } = "25";
                [XmlAttribute]
                public string r { get; set; } = "0.70";
                [XmlAttribute]
                public string g { get; set; } = "0.65";
                [XmlAttribute]
                public string b { get; set; } = "0.6";
                [XmlAttribute]
                public string attn { get; set; } = "0.0005";
                [XmlAttribute]
                public string range { get; set; } = "200";
                [XmlAttribute]
                public string t { get; set; } = @"Textures\rust1.png";
                [XmlAttribute]
                public string m { get; set; } = @"Materials\metal.xml";
                [XmlAttribute]
                public string c { get; set; } = "0x999999";
            }
            public class Windflags
            {
                [XmlAttribute]
                public string h { get; set; } = "4";
                [XmlAttribute]
                public string l { get; set; } = "4,1";
                [XmlAttribute]
                public string d { get; set; } = "0,6";
                [XmlAttribute]
                public string t { get; set; } = @"Textures\rust1.png";
                [XmlAttribute]
                public string m { get; set; } = @"Materials\metal.xml";
                [XmlAttribute]
                public string c { get; set; } = "0x999999";
            }
            public class Measurers
            {
                [XmlAttribute]
                public string c1 { get; set; } = "0xff0000";
                [XmlAttribute]
                public string c2 { get; set; } = "0xdddddd";
            }
            public class Label
            {
                [XmlAttribute(AttributeName = "summer-d")]
                public string summerd { get; set; } = "75";
                [XmlAttribute(AttributeName = "winter-d")]
                public string winterd { get; set; } = "75";
                [XmlAttribute]
                public string text { get; set; } = "DEFAULT";
                [XmlAttribute]
                public string textsize { get; set; } = "2,5";
            }
            public class Plastic
            {
                [XmlAttribute]
                public string c { get; set; } = "0x769391";
            }
            public class Lines
            {
                [XmlAttribute(AttributeName = "summer-min")]
                public string summermin { get; set; } = "105";
                [XmlAttribute(AttributeName = "summer-max")]
                public string summermax { get; set; } = "145";
                [XmlAttribute(AttributeName = "winter-min")]
                public string wintermin { get; set; } = "105";
                [XmlAttribute(AttributeName = "winter-max")]
                public string wintermax { get; set; } = "145";
            }
            public class Numbers
            {
                [XmlAttribute]
                public string min { get; set; } = "50";
                [XmlAttribute]
                public string max { get; set; } = "140";
            }
        }
        public class Profile
        {
            public Start start { get; set; }
            public Line line { get; set; }

            [XmlAttribute]
            public string id { get; set; } = "inrun-right";
            [XmlAttribute]
            public string side { get; set; } = "right";
            [XmlAttribute]
            public string maxstep { get; set; } = "1000";
            public class Start
            {
                [XmlAttribute]
                public string x { get; set; } = "-10";
                [XmlAttribute]
                public string y { get; set; } = "-1.0";
                [XmlAttribute]
                public string refx { get; set; } = "inrun";
            }
            public class Line
            {
                [XmlAttribute]
                public string x { get; set; } = "0";
                [XmlAttribute]
                public string y { get; set; } = "-1.0";
                [XmlAttribute]
                public string refx { get; set; } = "dhill";
            }
        }
        public class Terrain
        {
            public TerrainProfile profile { get; set; }
            public Trees trees { get; set; }
            public Blocks blocks { get; set; }
            public Houses houses { get; set; }
            public Audience audience { get; set; }

            public class TerrainProfile
            {
                [XmlAttribute(AttributeName = "in")]
                public string In { get; set; } = "0.7";
                [XmlAttribute]
                public string a0 { get; set; } = "5.0";
                [XmlAttribute]
                public string l0 { get; set; } = "50.0";
                [XmlAttribute]
                public string y0 { get; set; } = "-15.0";
                [XmlAttribute]
                public string hd { get; set; } = "13.5";
                [XmlAttribute]
                public string dd { get; set; } = "75.0";
                [XmlAttribute]
                public string sd { get; set; } = "30";
                [XmlAttribute]
                public string fd { get; set; } = "300";
                [XmlAttribute]
                public string sc { get; set; } = "0.07";
                [XmlAttribute]
                public string sm { get; set; } = "0.47";
                [XmlAttribute]
                public string rs { get; set; } = "1820";
                [XmlAttribute]
                public string c1 { get; set; } = "0x443920";
                [XmlAttribute]
                public string c2 { get; set; } = "0x5D603A";
                [XmlAttribute]
                public string tsc { get; set; } = "0.008";
                [XmlAttribute]
                public string tsm { get; set; } = "0.4";
            }
            public class Trees
            {
                [XmlAttribute]
                public string count { get; set; } = "10000";
                [XmlAttribute]
                public string minheight { get; set; } = "10";
                [XmlAttribute]
                public string maxheight { get; set; } = "20";
                [XmlAttribute]
                public string fractalthreshold { get; set; } = "0.8";
                [XmlAttribute]
                public string maxaltitude { get; set; } = "1600";
                [XmlAttribute]
                public string normalaltitude { get; set; } = "1000";
                [XmlAttribute]
                public string seed { get; set; } = "142";
            }
            public class Blocks
            {
                [XmlAttribute]
                public string count { get; set; } = "10";
                [XmlAttribute]
                public string minsaturation { get; set; } = "0.0";
                [XmlAttribute]
                public string maxsaturation { get; set; } = "0.1";
                [XmlAttribute]
                public string minfloors { get; set; } = "1";
                [XmlAttribute]
                public string maxfloors { get; set; } = "4";
                [XmlAttribute]
                public string maxaltitude { get; set; } = "1300";
                [XmlAttribute]
                public string normalaltitude { get; set; } = "1000";
                [XmlAttribute]
                public string fractalthreshold { get; set; } = "0.3";
                [XmlAttribute]
                public string seed { get; set; } = "258";
            }
            public class Houses
            {
                [XmlAttribute]
                public string count { get; set; } = "200";
                [XmlAttribute]
                public string minsaturation { get; set; } = "0.0";
                [XmlAttribute]
                public string maxsaturation { get; set; } = "0.2";
                [XmlAttribute]
                public string minfloors { get; set; } = "1";
                [XmlAttribute]
                public string maxfloors { get; set; } = "3";
                [XmlAttribute]
                public string maxaltitude { get; set; } = "1600";
                [XmlAttribute]
                public string normalaltitude { get; set; } = "1000";
                [XmlAttribute]
                public string fractalthreshold { get; set; } = "0.5";
                [XmlAttribute]
                public string seed { get; set; } = "156";
            }
            public class Audience
            {
                [XmlAttribute]
                public string count { get; set; } = "5000";
                [XmlAttribute]
                public string d { get; set; } = "50";
                [XmlAttribute]
                public string x0 { get; set; } = "-50";
                [XmlAttribute]
                public string seed { get; set; } = "4135";
            }
        }

        public class Stairs
        {
            [XmlAttribute]
            public string refx { get; set; } = "inrun";
            [XmlAttribute]
            public string lz { get; set; } = "2";
            [XmlAttribute]
            public string rz { get; set; } = "1";
            [XmlAttribute]
            public string c2 { get; set; } = "0xe8ebea";
            [XmlAttribute]
            public string m2 { get; set; } = @"Materials\material1.xml";
            [XmlAttribute]
            public string t2 { get; set; } = @"Textures\railing-glass.png";
            [XmlAttribute]
            public string c1 { get; set; } = "0xf2e5c7";
            [XmlAttribute]
            public string m1 { get; set; } = @"Materials\material1.xml";
            [XmlAttribute]
            public string t1 { get; set; } = @"Textures\rubbermat.png";
            [XmlAttribute]
            public string x1 { get; set; } = "0";
            [XmlAttribute]
            public string x2 { get; set; } = "20";
        }

        public class Railing
        {
            [XmlAttribute]
            public string refx1 { get; set; }
            [XmlAttribute]
            public string refx2 { get; set; }
            [XmlAttribute]
            public string guard { get; set; }
            [XmlAttribute]
            public string type { get; set; }
            [XmlAttribute]
            public string h { get; set; }
            [XmlAttribute]
            public string w { get; set; }
            [XmlAttribute]
            public string z1 { get; set; }
            [XmlAttribute]
            public string z2 { get; set; }
            [XmlAttribute]
            public string t { get; set; }
            [XmlAttribute]
            public string m { get; set; }
            [XmlAttribute]
            public string c { get; set; }
            [XmlAttribute]
            public string t3 { get; set; }
            [XmlAttribute]
            public string m3 { get; set; }
            [XmlAttribute]
            public string c3 { get; set; }
            [XmlAttribute]
            public string t6 { get; set; }
            [XmlAttribute]
            public string m6 { get; set; }
            [XmlAttribute]
            public string c6 { get; set; }
            [XmlAttribute]
            public string y { get; set; }

        }

        public class Pillar
        {
            [XmlAttribute]
            public string brefy { get; set; } = "terrain";
            [XmlAttribute]
            public string trefy { get; set; } = "inrun-top";
            [XmlAttribute]
            public string t { get; set; } = @"Textures\railing-glass.png";
            [XmlAttribute]
            public string m { get; set; } = @"Materials\material1.xml";
            [XmlAttribute]
            public string c { get; set; } = "0xf2e5c7";
            [XmlAttribute]
            public string x1 { get; set; } = "0";
            [XmlAttribute]
            public string x2 { get; set; } = "3";
            [XmlAttribute]
            public string refrz { get; set; } = "inrun-right";
            [XmlAttribute]
            public string reflz { get; set; } = "inrun-left";
            [XmlAttribute]
            public string top { get; set; } = "false";
            [XmlAttribute]
            public string ty { get; set; }
            [XmlAttribute]
            public string step { get; set; }
            [XmlAttribute]
            public string count { get; set; }
        }




    }
}
