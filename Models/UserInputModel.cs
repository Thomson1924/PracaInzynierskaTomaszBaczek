using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Models
{
    public class UserInputModel
    {
        [Required(ErrorMessage ="Please enter hill name.")]
        [StringLength(40, ErrorMessage = "Hill name is too long.")]
        public string HillName { get; set; } = "Hill";
        public string CountryCode { get; set; } = "POL";
        [Required]
        [Range(30,500, ErrorMessage ="Hill size must be between 30 and 500.")]
        public int HillSize { get; set; } = 140;
        public string JudgetowerColorOut { get; set; } = "0x959183";
        public string JudgetowerColorIn { get; set; } = "0x78554e";
        public string JudgetowerTextureOut { get; set; } = @"Textures\wood3.png";
        public string JudgetowerTextureIn { get; set; } = @"Textures\wood3.png";
        public string PillarTexture { get; set; } = @"Textures\railing-glass.png";
        public string PillarColor { get; set; } = "0xf2e5c7";
        public string RailingTexture { get; set; } = @"Textures\railing-glass.png";
        public string RailingColor { get; set; } = "0xf2e5c7";
        public string InrunColor { get; set; } = "0x97a594";
        public string PlasticColor { get; set; } = "0x769391";
        public string TerrainColor1 { get; set; } = "0x443920";
        public string TerrainColor2 { get; set; } = "0x5D603A";
        public string Trackstype { get; set; } = "ceramic";

    }
}
