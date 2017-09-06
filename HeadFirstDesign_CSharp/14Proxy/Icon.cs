using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace _14Proxy
{
    public interface Icon
    {
        int getIconWidth();
        int getIconHeight();
        void paintIcon();
    }
    public class ImageIcon : Icon
    {
        public int getIconHeight()
        {
            return 800;
        }

        public int getIconWidth()
        {
            return 600;
        }

        public void paintIcon()
        {
            Console.WriteLine("显示图片成功...");
        }
    }
    public class ImageProxy : Icon
    {
        ImageIcon imageIcon;
        Url imageURL;
        Thread retrievalThread;
        bool retrieving = false;

        public ImageProxy(Url url)
        {
            imageURL = url;
        }

        public int getIconHeight()
        {
            if (imageIcon!=null)
            {
                return imageIcon.getIconHeight();
            }
            else
            {
                return 600;
            }
        }

        public int getIconWidth()
        {
            if (imageIcon!=null)
            {
                return imageIcon.getIconWidth();
            }
            else
            {
                return 800;
            }
        }

        public void paintIcon()
        {
            if (imageIcon!=null)
            {
                imageIcon.paintIcon();
            }
            else
            {
                //...Java代码不方便移植
                retrievalThread = new Thread(()=>{

                });
                retrievalThread.Start();
            }
        }
    }
}
