using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestGame01
{
    public partial class FormSong : Form
    {
        private List<Song> songs = new List<Song>();
        public FormSong(List<Song> songs )
        {
            InitializeComponent();
            StartPosition = new Form().StartPosition;
            this.songs = songs;
            foreach (Song song in songs)
            {
                lsb_Song.Items.Add(song.Name);
                
            }
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lsb_Song_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Song Song_Selected
        {
            get
            
            {
                Song song1 = null;
                foreach (Song song in songs)
                {
                    if (song.Name == (string)lsb_Song.SelectedItem)
                    {
                        
                       song1 = song;
                    }
                }

                return song1;

            }
        }
    }
}
