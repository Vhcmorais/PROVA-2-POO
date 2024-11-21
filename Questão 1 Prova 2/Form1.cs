using System.Windows.Forms;

namespace Questão_1_Prova_2
{
    public partial class Form1 : Form
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        public Form1()
        {
            InitializeComponent();

            // Adicionando as colunas ao DataGridView
            dataGridView1.Columns.Add("Placa", "Placa");
            dataGridView1.Columns.Add("Ano", "Ano");
            dataGridView1.Columns.Add("TipoVeiculo", "Tipo de Veículo");
            dataGridView1.Columns.Add("Aluguel", "Aluguel Diário (R$)");

            // Adiciona opções no ComboBox
            cmbTipoVeiculos.Items.Add("Ônibus");
            cmbTipoVeiculos.Items.Add("Caminhão");
            cmbTipoVeiculos.SelectedIndex = 0; // Seleciona Ônibus como padrão

            // Ajusta DataGridView para selecionar linhas completas
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = txtPlaca.Text;
                int ano = int.Parse(txtAno.Text);
                Veiculo veiculo = null;

                // Verifica o tipo de veículo e cria a instância apropriada
                if (cmbTipoVeiculos.SelectedItem.ToString() == "Ônibus")
                {
                    int assentos = int.Parse(txtAssentosOuEixos.Text);
                    veiculo = new Onibus(placa, ano, assentos);
                }
                else if (cmbTipoVeiculos.SelectedItem.ToString() == "Caminhão")
                {
                    int eixos = int.Parse(txtAssentosOuEixos.Text);
                    veiculo = new Caminhao(placa, ano, eixos);
                }

                veiculos.Add(veiculo); // Adiciona o veículo à lista
                AtualizarDataGridView(); // Atualiza o DataGridView para mostrar o veículo adicionado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar veículo: " + ex.Message);
            }
        }
        private void AtualizarDataGridView()
        {
            {
                // Limpa as linhas do DataGridView
                dataGridView1.Rows.Clear();

                // Preenche o DataGridView com os dados da lista de veículos
                foreach (var veiculo in veiculos)
                {
                    string tipoVeiculo = veiculo is Onibus ? "Ônibus" : "Caminhão";
                    double aluguel = veiculo.Alugar();
                    string assentosOuEixos;

                    // Preenche a coluna de "Assentos" para ônibus e "Eixos" para caminhões
                    if (veiculo is Onibus onibus)
                    {
                        assentosOuEixos = onibus.Assentos.ToString(); // Número de assentos
                    }
                    else if (veiculo is Caminhao caminhao)
                    {
                        assentosOuEixos = caminhao.Eixos.ToString(); // Número de eixos
                    }

                    // Adiciona os dados na linha do DataGridView
                    dataGridView1.Rows.Add(veiculo.Placa, veiculo.Ano, tipoVeiculo, aluguel.ToString("0.00"));
                }
            }
        }

        private void cmbTipoVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVeiculos.SelectedItem.ToString() == "Ônibus")
            {
                lbl1.Text = "Número de Assentos:";
            }
            else if (cmbTipoVeiculos.SelectedItem.ToString() == "Caminhão")
            {
                lbl1.Text = "Número de Eixos:";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int indice = dataGridView1.SelectedRows[0].Index;

                // Remove o veículo da lista
                veiculos.RemoveAt(indice);

                // Atualiza o DataGridView
                AtualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Selecione um veículo para excluir.");
            }
        }
    }
}
