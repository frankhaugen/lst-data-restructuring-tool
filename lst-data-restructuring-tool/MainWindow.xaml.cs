using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lst_data_restructuring_tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "Tesssssssst";
        }

        // Android		SORTKEY:A_PlayableRace	FACT:BaseSize|M	SOURCEPAGE:p.42	RACETYPE:Humanoid		GROUP:RaceType_Humanoid		TYPE:Humanoid	MODIFY:RaceType_Humanoid|SET|True		RACESUBTYPE:Android	MOVE:Walk,0	GRANT:MOVEMENT|Walk	MODIFYOTHER:PC.MOVEMENT|Walk|Speed|SET|30	BONUS:VAR|Walk|30	MODIFY:Race_Legs|ADD|2	STARTFEATS:1	BONUS:STAT|DEX,INT|2	BONUS:STAT|CHA|-2								ABILITY:Race|AUTOMATIC|Android																			KIT:1|Playable Race Defaults	AUTO:LANG|Common					LANGBONUS:TYPE=Spoken

        

    }
}
