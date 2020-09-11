using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexNumConverter
{
    public partial class Converter : Form
    {
        FolderBrowserDialog fb = new FolderBrowserDialog();
        string sp = "";
        string op = "";

        Dictionary<int, int> convertDict = new Dictionary<int, int> { { 252, 298 },
{ 253, 360 },
{ 254, 424 },
{ 255, 429 },
{ 256, 430 },
{ 257, 438 },
{ 258, 439 },
{ 259, 440 },
{ 260, 446 },
{ 261, 458 },
{ 262, 461 },
{ 263, 462 },
{ 264, 463 },
{ 265, 464 },
{ 266, 465 },
{ 267, 466 },
{ 268, 467 },
{ 269, 468 },
{ 270, 469 },
{ 271, 470 },
{ 272, 471 },
{ 273, 472 },
{ 274, 473 },
{ 275, 474 },
{ 276, 252 },
{ 277, 253 },
{ 278, 254 },
{ 279, 255 },
{ 280, 256 },
{ 281, 257 },
{ 282, 258 },
{ 283, 259 },
{ 284, 260 },
{ 285, 280 },
{ 286, 281 },
{ 287, 282 },
{ 288, 475 },
{ 289, 292 },
{ 290, 352 },
{ 291, 374 },
{ 292, 375 },
{ 293, 376 },
{ 294, 399 },
{ 295, 442 },
{ 296, 448 },
{ 297, 443 },
{ 298, 444 },
{ 299, 445 },
{ 300, 303 },
{ 301, 345 },
{ 302, 346 },
{ 303, 347 },
{ 304, 348 },
{ 305, 408 },
{ 306, 409 },
{ 307, 410 },
{ 308, 411 },
{ 309, 289 },
{ 310, 359 },
{ 311, 355 },
{ 312, 356 },
{ 313, 477 },
{ 314, 321 },
{ 315, 493 },
{ 316, 387 },
{ 317, 388 },
{ 318, 389 },
{ 319, 390 },
{ 320, 391 },
{ 321, 392 },
{ 322, 393 },
{ 323, 394 },
{ 324, 395 },
{ 325, 299 },
{ 326, 476 },
{ 327, 679 },
{ 328, 680 },
{ 329, 681 },
{ 330, 624 },
{ 331, 625 },
{ 332, 405 },
{ 333, 306 },
{ 334, 330 },
{ 335, 350 },
{ 336, 373 },
{ 337, 601 },
{ 338, 571 },
{ 339, 700 },
{ 340, 382 },
{ 341, 383 },
{ 342, 384 },
{ 343, 483 },
{ 344, 484 },
{ 345, 487 },
{ 346, 486 },
{ 347, 491 },
{ 348, 649 },
{ 349, 643 },
{ 350, 644 },
{ 351, 646 },
{ 352, 407 },
{ 353, 426 },
{ 354, 428 },
{ 355, 286 },
{ 356, 291 },
{ 357, 354 },
{ 358, 479 },
{ 359, 579 },
{ 360, 547 },
{ 361, 553 },
{ 362, 563 },
{ 363, 596 },
{ 364, 598 },
{ 365, 607 },
{ 366, 608 },
{ 367, 609 },
{ 368, 612 },
{ 369, 623 },
{ 370, 771 },
{ 371, 707 },
{ 372, 663 },
{ 373, 778 },
{ 374, 637 },
{ 375, 633 },
{ 376, 634 },
{ 377, 635 },
{ 378, 380 },
{ 379, 381 },
{ 380, 386 },
{ 381, 385 },
};

        public Converter()
        {
            InitializeComponent();
            setOutput.Click += selectOutputFolder;
            setSprite.Click += selectSpriteFolder;
            activateButton.Click += convert;
        }

        private void selectSpriteFolder(object o, EventArgs e)
        {
            fb.ShowNewFolderButton = false;
            fb.Description = "select sprite folder";
            fb.ShowDialog();
            sp = fb.SelectedPath;
            spriteFolderPath.Text = sp;
        }

        private void selectOutputFolder(object o, EventArgs e)
        {
            fb.ShowNewFolderButton = true;
            fb.Description = "select output folder";
            fb.ShowDialog();
            op = fb.SelectedPath;
            outputFolderPath.Text = op;
        }

        private void convert(object o, EventArgs e)
        {
            if (sp != "" && op != "")
            {
                string[] direc = Directory.GetFiles(sp);
                foreach (string filePath in direc)
                {
                    pBar.Visible = true;
                    pBar.Maximum = direc.Length;
                    pBar.Minimum = 1;
                    pBar.Step = 1;
                    pBar.PerformStep();

                    string bakestring = op + "\\";
                    Console.WriteLine(bakestring);
                    string[] cName = Path.GetFileName(filePath).Split(".");
                    if (Path.GetExtension(filePath) == ".png" && cName.Length < 4)
                    {
                        try
                        {
                            Console.WriteLine("trying " + Path.GetFileName(filePath));
                            int head = Convert.ToInt32(cName[0]);
                            int body = Convert.ToInt32(cName[1]);
                            int trip = 0;

                            if (convertDict.ContainsKey(head))
                            {
                                head = convertDict[head];
                            }
                            bakestring += head + ".";

                            if (convertDict.ContainsKey(body))
                            {
                                body = convertDict[body];
                            }
                            bakestring += body + ".";

                            if (cName.Length == 4)
                            {
                                trip = Convert.ToInt32(cName[2]);
                                if (convertDict.ContainsKey(trip))
                                {
                                    trip = convertDict[trip];
                                }
                                bakestring += trip + ".";
                            }
                            bakestring += "png";

                            File.Copy(filePath, bakestring);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            } 
        }
    }
}
