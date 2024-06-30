using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhotoGallery
{
    public partial class PhotoGallery : System.Web.UI.Page
    {
        private string[] _images;
        private int _currentIndex;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadImages();
                DisplayImage(0);
            }
            else
            {
                _images = (string[])ViewState["Images"];
                _currentIndex = (int)ViewState["CurrentIndex"];
            }
        }

        private void LoadImages()
        {
            string imagesFolder = Server.MapPath("~/Images");
            _images = Directory.GetFiles(imagesFolder);
            ViewState["Images"] = _images;
            ViewState["CurrentIndex"] = 0;
        }

        private void DisplayImage(int index)
        {
            if (_images != null && _images.Length > 0)
            {
                _currentIndex = index;
                string relativePath = $"~/Images/{Path.GetFileName(_images[index])}";
                imgPhoto.ImageUrl = relativePath;
                lblFileName.Text = Path.GetFileName(_images[index]);
                ViewState["CurrentIndex"] = _currentIndex;
            }
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            DisplayImage(0);
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            _currentIndex = (int)ViewState["CurrentIndex"];
            if (_currentIndex > 0)
            {
                DisplayImage(_currentIndex - 1);
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            _currentIndex = (int)ViewState["CurrentIndex"];
            if (_currentIndex < _images.Length - 1)
            {
                DisplayImage(_currentIndex + 1);
            }
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            DisplayImage(_images.Length - 1);
        }
    }
}