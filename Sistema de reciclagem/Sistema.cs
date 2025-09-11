using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace Sistema_de_reciclagem
{
    public static class Sistema
    {
        private static readonly string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados");
        private static readonly string arquivoMateriais = Path.Combine(pastaDados, "materiais.json");
        private static readonly string arquivoCompras = Path.Combine(pastaDados, "compras.json");

        public static List<Material> Materiais { get; private set; } = new List<Material>();
        public static List<Compra> Compras { get; private set; } = new List<Compra>();

        public static void Salvar()
        {
            if (!Directory.Exists(pastaDados)) Directory.CreateDirectory(pastaDados);

            File.WriteAllText(arquivoMateriais, JsonSerializer.Serialize(Materiais, new JsonSerializerOptions { WriteIndented = true }));
            File.WriteAllText(arquivoCompras, JsonSerializer.Serialize(Compras, new JsonSerializerOptions { WriteIndented = true }));
        }

        public static void Carregar()
        {
            if (File.Exists(arquivoMateriais))
            {
                Materiais = JsonSerializer.Deserialize<List<Material>>(File.ReadAllText(arquivoMateriais)) ?? new List<Material>();
            }

            if (File.Exists(arquivoCompras))
            {
                Compras = JsonSerializer.Deserialize<List<Compra>>(File.ReadAllText(arquivoCompras)) ?? new List<Compra>();
            }
        }
    }
}
