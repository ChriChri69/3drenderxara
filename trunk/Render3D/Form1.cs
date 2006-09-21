/*
Render3D - Rendering 3D Text thanks to the Xara WebService
Copyright (C) 2006  Christian-Cyril CORDAT

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Render3D
{
    public partial class Form1 : Form
    {
        // paramètres du rendu
        string templateRender, fontRender, exporttypeRender, textcolorRender, bgcolorRender, textsizeRender, texttoRender, url;
        // informations sur l'image résultante
        long width, height;
        // le web service de rendering
        Render3D.com.xara.ws.RenderServer3D Render;
        // le webclient qui permet de télécharger l'image
        private WebClient webc = null;

        // pour la conversion de couleur en hexa
        private static char[] tab_hexa = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        private string HexaString(int valeur)
        {
            return tab_hexa[valeur / 16].ToString() + tab_hexa[valeur % 16].ToString();
        }

        public Form1()
        {
            InitializeComponent();
            templateRender = "123Round";
            texttoRender = "Hello";
            textcolorRender = "000000";
            bgcolorRender = "ffffff";
            fontRender = "Arial";
            textsizeRender = "60";
            exporttypeRender = "jpg";
            Render = new Render3D.com.xara.ws.RenderServer3D();
            webc = new WebClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textRender.Text = texttoRender;
            this.sizeRender.Text = textsizeRender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                templateRender = this.templateChoice.SelectedItem.ToString();
                texttoRender = this.textRender.Text.ToString();
                fontRender = this.fontChoice.SelectedItem.ToString();
                textsizeRender = this.sizeRender.Text.ToString();
                exporttypeRender = this.exportChoice.SelectedItem.ToString();

                // requete pour obtenir l'URL de l'image générée
                url = Render.RenderURL(templateRender, texttoRender, textcolorRender, bgcolorRender, fontRender, textsizeRender, exporttypeRender, out width, out height);
                this.richTextBox1.Clear();
                this.richTextBox1.Text += url + "\n";

                // on télécharge l'image puis on l'affiche
                string filename = "temp." + exporttypeRender.ToString();
                webc.DownloadFile(url.ToString(), filename.ToString());
                this.pictureRender.ImageLocation = filename;
                this.pictureRender.Visible = true;
            }
            catch (WebException webex)
            {
                Console.WriteLine(webex.ToString()+" "+url.ToString());
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            // pour obtenir les paramètres disponibles du webservice
            object[] templates = Render.GetTemplates();
            object[] fonts = Render.GetFonts();
            object[] exporttypes = Render.GetExportTypes();
            this.templateChoice.Items.Clear();
            this.templateChoice.Items.AddRange(templates);
            this.fontChoice.Items.Clear();
            this.fontChoice.Items.AddRange(fonts);
            this.exportChoice.Items.Clear();
            this.exportChoice.Items.AddRange(exporttypes);
            this.templateChoice.SelectedIndex = 0;
            this.fontChoice.SelectedIndex = 0;
            this.exportChoice.SelectedIndex = 0;
        }

        private void textcolor_Click(object sender, EventArgs e)
        {
            if (this.textcolorDialog.ShowDialog() == DialogResult.OK)
            {
                this.textcolor.BackColor = this.textcolorDialog.Color;
                textcolorRender = HexaString(Convert.ToInt32(this.textcolorDialog.Color.R)) + HexaString(Convert.ToInt32(this.textcolorDialog.Color.G)) + HexaString(Convert.ToInt32(this.textcolorDialog.Color.B));
            }
        }

        private void bgcolor_Click(object sender, EventArgs e)
        {
            if (this.bgcolorDialog.ShowDialog() == DialogResult.OK)
            {
                this.bgcolor.BackColor = this.bgcolorDialog.Color;
                bgcolorRender = HexaString(Convert.ToInt32(this.bgcolorDialog.Color.R)) + HexaString(Convert.ToInt32(this.bgcolorDialog.Color.G)) + HexaString(Convert.ToInt32(this.bgcolorDialog.Color.B));
            }
        }
    }
}