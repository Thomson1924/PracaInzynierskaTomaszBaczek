using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracaInżynierskaTomaszBaczek.Models;

namespace PracaInżynierskaTomaszBaczek.Pages
{
    public class TexturesAndMaterials : ComponentBase
    {
        public List<Texture> Textures { get; set; }

        protected override Task OnInitializedAsync()
        {
            Textures = new List<Texture>()
            {
            new Texture() { Name = @"Textures\carpet.png", Displayname = "Carpet", Imgpath = "" },
            new Texture() { Name = @"Textures\concrete-lillehammer.png", Displayname = "Concrete Lillehammer" },
            new Texture() { Name = @"Textures\concrete1.png", Displayname = "Concrete 1"},
            new Texture() { Name = @"Textures\concrete2.png", Displayname = "Concrete 2"},
            new Texture() { Name = @"Textures\concrete3.png", Displayname = "Concrete 3"},
            new Texture() { Name = @"Textures\concrete4.png", Displayname = "concrete 4"},
            new Texture() { Name = @"Textures\concrete5.png", Displayname = "Concrete 5"},
            new Texture() { Name = @"Textures\concrete6.png", Displayname = "Concrete 6"},
            new Texture() { Name = @"Textures\corrugatedb.png", Displayname = "Corrugatedb"},
            new Texture() { Name = @"Textures\grating1.png", Displayname = "Grating 1"},
            new Texture() { Name = @"Textures\grating2.png", Displayname = "Grating 2"},
            new Texture() { Name = @"Textures\grating3.png", Displayname = "Grating 3"},
            new Texture() { Name = @"Textures\grid.png", Displayname = "Grid 1"},
            new Texture() { Name = @"Textures\grid2.png", Displayname = "Grid 2"},
            new Texture() { Name = @"Textures\horizontal-wires.png", Displayname = "Horizontal wires"},
            new Texture() { Name = @"Textures\horizontal-wires2.png", Displayname = "Horizontal wires 2"},
            new Texture() { Name = @"Textures\metal.png", Displayname = "Metal"},
            new Texture() { Name = @"Textures\net.png", Displayname = "Net"},
            new Texture() { Name = @"Textures\plate1.png", Displayname = "Plate"},
            new Texture() { Name = @"Textures\plate2.png", Displayname = "Plate 2"},
            new Texture() { Name = @"Textures\railing-glass-cut.png", Displayname = "Railing glass cut"},
            new Texture() { Name = @"Textures\railing-glass.png", Displayname = "Railing glass"},
            new Texture() { Name = @"Textures\rock.png", Displayname = "Rock"},
            new Texture() { Name = @"Textures\rubbermat.png", Displayname = "Rubber mat"},
            new Texture() { Name = @"Textures\rust1.png", Displayname = "Rust"},
            new Texture() { Name = @"Textures\snow.png", Displayname = "Snow"},
            new Texture() { Name = @"Textures\stone1.jpg", Displayname = "Stone"},
            new Texture() { Name = @"Textures\tiles1.png", Displayname = "Tiles"},
            new Texture() { Name = @"Textures\tiles2.png", Displayname = "Tiles 2"},
            new Texture() { Name = @"Textures\tiles3.png", Displayname = "Tiles 3"},
            new Texture() { Name = @"Textures\vertical-wires.png", Displayname = "Vertical wires"},
            new Texture() { Name = @"Textures\window.png", Displayname = "Window"},
            new Texture() { Name = @"Textures\wood1.png", Displayname = "Wood 1"},
            new Texture() { Name = @"Textures\wood1b.png", Displayname = "Wood 1b"},
            new Texture() { Name = @"Textures\wood2.png", Displayname = "Wood 2"},
            new Texture() { Name = @"Textures\wood2b.png", Displayname = "Wood 2b"},
            new Texture() { Name = @"Textures\wood3.png", Displayname = "Wood 3"},
            new Texture() { Name = @"Textures\wood3b.png", Displayname = "Wood 3b"},
            new Texture() { Name = @"Textures\wood4.png", Displayname = "Wood 4"},
            new Texture() { Name = @"Textures\wood4b.png", Displayname = "Wood 4b"},
            new Texture() { Name = @"Textures\wood5.png", Displayname = "Wood 5"},
            new Texture() { Name = @"Textures\wood5b.png", Displayname = "Wood 5b"},
            new Texture() { Name = @"Textures\wood6.png", Displayname = "Wood 6"},
            new Texture() { Name = @"Textures\wood7.png", Displayname = "Wood 7"}
            };
            return base.OnInitializedAsync();
        }

    }
}
