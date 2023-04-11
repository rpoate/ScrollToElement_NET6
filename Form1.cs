using System.Linq.Expressions;

namespace ScrollToElement_NET6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.htmlEditControl1.CSSText = "body {font-family: Calibri; font-size: 12pt}";
            this.htmlEditControl1.DocumentHTML = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sit amet est lacus. Duis interdum risus eget metus " +
                "vulputate aliquet. Donec feugiat urna at dolor laoreet, sed venenatis lorem euismod. Etiam ante mi, dictum id lectus eget, finibus convallis felis. " +
                "Vivamus bibendum sed diam ac varius. Nunc sed ligula ac ex iaculis tincidunt. Aliquam sit amet malesuada eros. Praesent at volutpat lacus. Nullam iaculis " +
                "nibh nec sapien hendrerit, quis venenatis est ullamcorper. Quisque tempor placerat nibh, eu efficitur arcu condimentum sit amet. " +
                "Proin ultrices sapien libero, nec ultricies nulla fringilla sit amet. Mauris eu mattis nulla. Duis metus velit, suscipit nec pellentesque ac, " +
                "interdum sed lorem. In sit amet tellus eget lacus convallis convallis. </p>" +
                "<p>Praesent vitae ornare velit. Pellentesque id nulla quis nisl imperdiet blandit ut sed tortor. Etiam tincidunt lobortis blandit. " +
                "Vestibulum porta viverra tortor, ut tempor purus molestie eu. Cras auctor dolor vitae turpis sodales scelerisque. Sed auctor nec lacus at malesuada. " +
                "Etiam fermentum accumsan efficitur. Pellentesque sed enim nec augue tempor aliquet. </p>" +
                "<p>Duis hendrerit fringilla lobortis. Mauris in luctus lectus. Ut eget libero metus. Pellentesque habitant morbi tristique senectus et netus et malesuada " +
                "fames ac turpis egestas. Etiam arcu ipsum, rutrum eu laoreet ut, ultrices egestas odio. Vivamus ullamcorper libero id erat feugiat suscipit. Nulla vitae " +
                "tincidunt erat, ultrices pretium neque. Fusce a congue dui. Fusce venenatis blandit nunc a dictum. Mauris euismod mattis nisl sit amet semper. Etiam " +
                "imperdiet quam ipsum, ac luctus est placerat vitae. Integer auctor leo a blandit aliquam. Nam elementum libero quam, vitae maximus velit placerat non. " +
                "Maecenas viverra massa a velit commodo, eget dictum metus aliquam. Mauris eu metus nisl. Aliquam est ligula, sagittis ut semper in, porttitor quis dui. </p>" +
                "<img src='https://zoople.tech/img/logo.png' align='right' /><p>Duis porttitor, erat sed sodales elementum, ligula elit mollis enim, at condimentum mauris sem sed neque. Cras sit amet ultricies dui, eu scelerisque " +
                "tellus. Duis pretium suscipit vestibulum. Integer vehicula pellentesque lectus, eu ullamcorper eros malesuada non. Praesent pulvinar sapien quis tortor " +
                "dapibus facilisis. Curabitur auctor justo risus, pretium ornare velit elementum sed. Suspendisse venenatis faucibus dui vitae semper. Mauris at eros leo. " +
                "Praesent consequat venenatis arcu, nec maximus nulla mattis non. Fusce vitae placerat magna. Nulla a dolor turpis. Vivamus elit velit, " +
                "consequat semper sapien vel, sagittis aliquet libero. Sed laoreet, purus vitae porta laoreet, nibh erat finibus tellus, ut lacinia diam justo non massa. " +
                "Nulla mollis massa enim. </p>" +
                "<p>Maecenas bibendum tellus et quam pellentesque, vitae tincidunt enim elementum. Sed pharetra vitae erat vitae viverra. Fusce imperdiet finibus nisi in " +
                "ultricies. Pellentesque iaculis dui vel lacus elementum scelerisque. Nulla congue facilisis massa vel efficitur. Donec accumsan arcu et porta vehicula. " +
                "Aenean varius libero mauris, vitae volutpat ante sodales sed. Vestibulum ac urna egestas, cursus libero blandit, tempor sapien. Etiam id metus in lacus " +
                "convallis cursus non nec sapien. Phasellus vitae diam sollicitudin, bibendum tellus finibus, vestibulum mauris. Sed eu vestibulum neque. </p>";

            var btn1 = this.htmlEditControl1.ToolStripItems.Add("Scroll To First Image");
            btn1.Padding = new Padding(3);
            btn1.BackColor = SystemColors.ControlDarkDark;
            btn1.ForeColor = SystemColors.HighlightText;
            btn1.Click += Btn1_Click;

        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            try
            {
                var FirstImage = this.htmlEditControl1.GetItemsByTagName("img")[0];
                FirstImage.ScrollIntoView(true);
            }
            catch { }
        }
    }
}