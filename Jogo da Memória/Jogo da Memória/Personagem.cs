using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória
{
    public class Personagem
    {
        public string Nome { get; set; }
        public PictureBox FalaInicio { get; set; }
        public PictureBox FalaTempoFaltando { get; set; }
        public PictureBox FalaAleatoria1Ivy { get; set; }
        public PictureBox FalaAleatoria1Jorge { get; set; }
        public PictureBox FalaAleatoria2Ivy { get; set; }
        public PictureBox FalaAleatoria2Jorge { get; set; }
        public PictureBox FalaAcerto { get; set; }
        public PictureBox FalaErro { get; set; }
        public PictureBox FalaAcabouOTempo { get; set; }
    }
}
