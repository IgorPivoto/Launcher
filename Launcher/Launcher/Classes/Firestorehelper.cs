using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Classes
{
    internal static class Firestorehelper
    {
        static string fireconfiguração = @"
        {
        ""type"": ""service_account"",
        ""project_id"": ""launcherradianta"",
        ""private_key_id"": ""044cdd91aa655efa96469445f46faafbeb96162f"",
        ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDhAo7rP+252nv0\ncYCnGbVSCWrer5G8J4r5MO1MJyJp6oU8F73mlAZ4oiN9lmfL/eKJOV+I2h/uNULl\nXpTcwyuKy2B62WiCuaHQC5b2E753TRPUdopc80Bw2TxdeDlkFgE/H3GB++JUKMCq\n68Z8xkQy8IJeE/Q412Hi9Lm/V1E91FQ1+ubT05Hdr4e3FaDpziNDlpaeSZY3d2tE\nk78K1Nb0qV248mdaNhkIbozgngiZViu074sSC3tQ9HPhHHIUdHTmnHdlIPz2aeBT\n41i8ztspo+1ygkFftgDbUs/WztElni3/FWOCqHI84Em3gUzeWeUlsbsqLK2fWWu9\nUOMGt1VLAgMBAAECggEAB3j+xxhN7FSxtioI1EPZzjoq1u9svxtvFZyG3PcVwP+9\nYgQF1gEHf/0egZ67nr41Rkpl/lUEJ3SUXqq39ebzbL4ZW6sZufGxSogAAPch5bNl\nG7K+IJ0hgD3ur8n82fKTIwYHzoHPf+0EjQichGtPO4PaSIaQH00j3pYzDwQ22f9B\nv8UxOIj+Pt4m+X2Vz7K0Skl4aZ9zlLBr1IooWhKIpE3CxfsHSUhPQRzN8VuWd3gu\nydqTHH6uZhO0Yncv6I0HE23HLpM1q1u7x7n5Datmw3HvPp40NNpyxxqGIhpwmUef\noi6XuGfXND2KRGBPUJrQrp4jJyet4SuQAueAm0R2uQKBgQD9Q6pYZg9AMTfpqJmq\nnK2+da0pSYxLKfUfyeG1+6mrVqxsr/uCOG1+sUAN8Rrdf+h3V57LkE9vIkJnVBnm\n4ZFLMCx6vJnzSIx5W7DONpshwtpBNVCecc9519JzDerXwzYp2mAiVqV8GOQa/r7b\nglTqqHKmlNOss0RGjN5K1xslOQKBgQDjcMNaxE9fKFVKeIL72ttaKSeByTMBwkps\nTMQpYLFZghCTNGO4k4LKg97NQF9fqzNzyWygzL3iGlXH1zhAinaGozlH1bTSctS9\nqQJmz07m/1FTQNieZOnsR0Yc1+DkbBV1Bc5gwMsyWjzuc8QvRFzOkOkCb35nF8kG\nFSh+GfWyowKBgQDVHNo7lm3g20msUZY07bB54vW6F0x5dy3v+OX4R3NnXQCsWI1v\n72GbyTUYRjkQB/Cqc82Ih79/yblMz4UYNdkYBsp24Ts+b17dQ92MOIDjsN4NHvre\nyPAIHCbXb++cbYSnRT29x2FrAlr3qEMb3RjteJ85M2THHvYl06W+HjGWaQKBgD7y\nRH7oefciGIjl1YqSxcasQSzgXGeOOD7E+D1jb3IQVzoGc9rvqHEYEh/IQx0dKr5O\n7uuJ/ruHAlquq/jg2XDl18KT2NmtwkdDcVC262VvIDjkZ49e6obkKvlsnedaKo4a\nr0WD1jj3VInCLHfQeccJwBNWfCtYH+C5Fl3gHWn1AoGBAMZ7JJ2nGJBCLLM51ux3\nV5Rv7EQIV4JAmJopnBkeKgJQnPWguLrCQpeikmQjrpcKv/mTwv4P+1dG0YREphsI\nO6yMoew2wtIQZZ/oT1IcIdwtjFIOdVm+JI3wS6bEGhdL9lrAyIVR3J6eTgYX2zzX\n4PGwERiLFlPCrg0zOQbiPFsL\n-----END PRIVATE KEY-----\n"",
        ""client_email"": ""firebase-adminsdk-tgsxt@launcherradianta.iam.gserviceaccount.com"",
        ""client_id"": ""106820076831672735162"",
        ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
        ""token_uri"": ""https://oauth2.googleapis.com/token"",
        ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
        ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-tgsxt%40launcherradianta.iam.gserviceaccount.com"",
        ""universe_domain"": ""googleapis.com""
        }";

        static string filepath = "";

        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfiguração);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("launcherradianta"); 
            File.Delete(filepath);
        }

    }
}
