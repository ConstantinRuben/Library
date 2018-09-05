using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAplication
{
    [Serializable]
    class BookCover
    {
        Image cover;
        string photoId;

      
        public BookCover()
        {
                
        }

        public BookCover(Image cover, string photoId)
        {
            this.cover = cover;
            this.photoId = photoId;
        }

        public Image get()
        {
            return cover;
        }
        public string PhotoId { get => photoId; set => photoId = value; }


    }


}
