using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Classes
{
    [FirestoreData]

    internal class DadosdoUsuario
    {
        [FirestoreProperty]
        
        public string? Nome { get; set; }
        [FirestoreProperty]
        
        public string? Email { get; set; }
        [FirestoreProperty]
        
        public string? Senha { get; set; }
        [FirestoreProperty]
        
        public string? ConfirmaSenha { get; set; }

    }
}
