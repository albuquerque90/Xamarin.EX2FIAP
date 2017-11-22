using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.EX2FIAP.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.EX2FIAP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoView : ContentPage
    {
        AlunoViewModel vmAluno;

        public AlunoView()
        {
            var aluno = AlunoViewModel.GetAluno();
            vmAluno = new AlunoViewModel(aluno);
            BindingContext = vmAluno;
            InitializeComponent();
        }
    }
}