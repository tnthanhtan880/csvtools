using System.Data;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSVTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DefaultSetting();
        }

        public void DefaultSetting()
        {
            DataGridViewCellStyle cell_style = new DataGridViewCellStyle();
            cell_style.BackColor = Color.LightSlateGray;
            cell_style.Alignment = DataGridViewContentAlignment.MiddleRight;

            // PaddingZero(checkbox)
            dataGridView1.Columns[2].ReadOnly = true;

            // PaddingZero
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[3].DefaultCellStyle = cell_style;

            // IsRandom
            dataGridView1.Columns[4].ReadOnly = true;

            // StartValue
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[5].DefaultCellStyle = cell_style;

            // EndValue
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[6].DefaultCellStyle = cell_style;

            // Rangedata
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[7].DefaultCellStyle = cell_style;

            // Dateformat
            dataGridView1.Columns[8].ReadOnly = true;
            dataGridView1.Columns[8].DefaultCellStyle = cell_style;

            chkSplitFile.Checked = false;
            lblLinePerFile1.Hide();
            tbxLinePerFile.Hide();
            lblLinePerFile2.Hide();

            //tbxLinePerFile.Text = "0";
        }

        private void chkSplitFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSplitFile.CheckState == CheckState.Checked)
            {
                lblLinePerFile1.Show();
                tbxLinePerFile.Show();
                lblLinePerFile2.Show();

                tbxLinePerFile.Text = "1";
            }
            else
            {
                lblLinePerFile1.Hide();
                tbxLinePerFile.Hide();
                lblLinePerFile2.Hide();

                tbxLinePerFile.Text = "0";
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbxOutputLocation.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void tbxOutputLocation_Click(object sender, EventArgs e)
        {
            tbxOutputLocation.SelectAll();
        }

        private void enableRow(DataGridViewCell row, bool isEnable)
        {
            DataGridViewCellStyle cell_style_disable = new DataGridViewCellStyle();
            cell_style_disable.BackColor = Color.LightSlateGray;
            cell_style_disable.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewCellStyle cell_style_enabled = new DataGridViewCellStyle();
            cell_style_enabled.BackColor = Color.White;
            cell_style_enabled.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (isEnable)
            {
                row.ReadOnly = false;
                row.Style = cell_style_enabled;
            }
            else
            {
                row.ReadOnly = true;
                row.Style = cell_style_disable;
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle cell_style_disable = new DataGridViewCellStyle();
            cell_style_disable.BackColor = Color.LightSlateGray;
            cell_style_disable.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewCellStyle cell_style_enabled = new DataGridViewCellStyle();
            cell_style_enabled.BackColor = Color.White;
            cell_style_enabled.Alignment = DataGridViewContentAlignment.MiddleRight;

            string cellVal = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                cellVal = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            if (cellVal == "Number")
            {
                // PaddingZero(checkbox)
                dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = false;

                // IsRandom
                dataGridView1.Rows[e.RowIndex].Cells[4].ReadOnly = false;

                // StartValue
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[5], true);

                // EndValue
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[6], true);

                // Rangedata
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[7], true);

                // Dateformat
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[8], false);

                // Maxlength
                dataGridView1.Rows[e.RowIndex].Cells[8].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[9], true);
            }
            else if (cellVal == "Date")
            {
                // PaddingZero(checkbox)
                dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = false;
                dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.LightSlateGray;

                // PaddingZero
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[3], false);

                // IsRandom
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = false;

                // StartValue
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[5], false);

                // EndValue
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[6], false);

                // Rangedata
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[7], false);

                // Dateformat
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[8], true);

                // Maxlength
                dataGridView1.Rows[e.RowIndex].Cells[8].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[9], false);

                // PrefixValue
                dataGridView1.Rows[e.RowIndex].Cells[10].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[10], false);
            }
            else if (cellVal != "")
            {
                // PaddingZero(checkbox)
                dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = false;
                dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.LightSlateGray;
                // PaddingZero
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[3], false);

                // IsRandom
                dataGridView1.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = false;
                dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.LightSlateGray;
                // StartValue
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[5], false);

                // EndValue
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[6], false);

                // Rangedata
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[7], true);

                // Dateformat
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[8], false);
                dataGridView1.Rows[e.RowIndex].Cells[8].Style.SelectionBackColor = Color.Red;

                // Maxlength
                dataGridView1.Rows[e.RowIndex].Cells[8].Value = "";
                enableRow(dataGridView1.Rows[e.RowIndex].Cells[9], true);
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // 3~8
            if (e.ColumnIndex == 3 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 9)
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i) && e.FormattedValue != string.Empty)
                {
                    e.Cancel = true;
                    MessageBox.Show("Nhap lai dum!!! Nhap so!!!", "Nhap tao lao");
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }

        private bool inputValCheck()
        {
            if (string.IsNullOrEmpty(tbxFilename.Text))
            {
                MessageBox.Show("-> Tên không được để rỗng", "Lỗi parameter");
                tbxFilename.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtLineNumber.Text))
            {
                MessageBox.Show("-> Số dòng khởi tạo CSV không được rỗng", "Lỗi parameter");
                txtLineNumber.Focus();
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(txtLineNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("-> Vui lòng nhập [Line Number] là số", "Lỗi parameter");
                txtLineNumber.Focus();
            }

            if (chkSplitFile.Checked)
            {
                if (string.IsNullOrEmpty(tbxLinePerFile.Text))
                {
                    MessageBox.Show("-> Số dòng cắt không được rỗng", "Lỗi parameter");
                    tbxLinePerFile.Focus();
                    return false;

                }
            }

            if (string.IsNullOrEmpty(tbxOutputLocation.Text))
            {
                MessageBox.Show("-> Thư mục lưu trữ không được rỗng", "Lỗi parameter");
                tbxOutputLocation.Focus();
                return false;
            }
            else
            {
                if (!Directory.Exists(tbxOutputLocation.Text))
                {
                    MessageBox.Show("-> Thư mục lưu trữ không tồn tại", "Lỗi parameter");
                    tbxOutputLocation.Focus();
                    return false;
                }

                if (tbxFilename.Text.Length > 4)
                {
                    string subFixFile = tbxFilename.Text.Substring(tbxFilename.Text.Length - 4, 4);
                    if (subFixFile != ".csv")
                    {
                        MessageBox.Show("-> Chỉ hỗ trợ CSV", "Lỗi parameter");
                        tbxFilename.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("-> Tên file không hợp lệ", "Lỗi parameter");
                    tbxFilename.Focus();
                    return false;
                }
            }

            int cntValid = 0;
            List<int> arrIndexValid = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string headerVal = Convert.ToString(row.Cells[0].Value);
                string typeVal = Convert.ToString(row.Cells[1].Value);
                if (row.IsNewRow && dataGridView1.Rows.Count != 1)
                {
                    continue;
                }

                if (string.IsNullOrEmpty(headerVal) || string.IsNullOrEmpty(typeVal))
                {
                    arrIndexValid.Add(row.Index + 1);
                    cntValid++;
                }
            }

            if (cntValid > 0)
            {
                MessageBox.Show("-> Nhập định dạng CSV ở dòng [" + string.Join(", ", arrIndexValid) + "]", "Lỗi parameter");
                return false;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                switch (Convert.ToString(row.Cells[1].Value))
                {
                    case "Number":
                        if (Convert.ToBoolean(row.Cells[2].Value))
                        {
                            if (string.IsNullOrEmpty(Convert.ToString(row.Cells[3].Value)))
                            {
                                MessageBox.Show("-> Nhập [PaddingZero] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                                return false;
                            }
                        }

                        string startVal = Convert.ToString(row.Cells[5].Value);
                        string endVal = Convert.ToString(row.Cells[6].Value);
                        string rangeVal = Convert.ToString(row.Cells[7].Value);

                        if (string.IsNullOrEmpty(startVal) && string.IsNullOrEmpty(endVal) && string.IsNullOrEmpty(rangeVal))
                        {
                            MessageBox.Show("-> Vui lòng nhập [StartValue - Endvalue] hoặc [RangeValue] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                            return false;
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(startVal) && !string.IsNullOrEmpty(endVal))
                            {
                                if (Convert.ToInt32(startVal) > Convert.ToInt32(endVal))
                                {
                                    MessageBox.Show("-> Không thể nhập [StartValue] lớn hơn [EndValue] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                                    return false;
                                }

                                if (Convert.ToInt32(endVal) < Convert.ToInt32(txtLineNumber.Text))
                                {
                                    MessageBox.Show("-> [EndValue] phải lớn hơn hoặc bằng [Line number] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                                    return false;
                                }

                                if ((Convert.ToInt32(endVal) - Convert.ToInt32(startVal)) < Convert.ToInt32(txtLineNumber.Text))
                                {
                                    MessageBox.Show("-> Số lượng [StartValue] - [EndValue] nhỏ hơn số lượng [LineNumber] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                                    return false;
                                }
                            }

                            if (!string.IsNullOrEmpty(startVal) && string.IsNullOrEmpty(endVal))
                            {
                                MessageBox.Show("-> Vui lòng nhập [EndValue] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                                return false;
                            }

                        }
                        break;
                    case "Date":
                        if (string.IsNullOrEmpty(Convert.ToString(row.Cells[8].Value)))
                        {
                            MessageBox.Show("-> Vui lòng chọn [DateFormat] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                            return false;
                        }
                        break;
                    case "String":
                        break;
                    default:
                        break;
                }
            }


            return true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool valCheck = inputValCheck();

            if (valCheck)
            {
                var csv = new StringBuilder();

                // Create the CSV file to which grid data will be exported.
                StreamWriter sw = new StreamWriter(tbxOutputLocation.Text + "\\" + tbxFilename.Text, false);

                // First we will write the headers.
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (i != 0)
                    {
                        sw.Write(",");
                    }
                    sw.Write(dataGridView1.Rows[i].Cells[0].Value);
                }

                sw.Write(sw.NewLine);

                // Now write all the rows.
                int idxRangeLst = 0;
                for (int i = 0; i <= Convert.ToInt32(txtLineNumber.Text) - 1; i++)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string writeValue = "";
                        switch (Convert.ToString(row.Cells[1].Value))
                        {
                            case "Number":
                                string valueInit = Convert.ToString(row.Cells[10].Value);
                                int startVal = Convert.ToInt32(row.Cells[5].Value);
                                if (!string.IsNullOrEmpty(Convert.ToString(startVal)) && !string.IsNullOrEmpty(Convert.ToString(row.Cells[6].Value)))
                                {
                                    if (Convert.ToBoolean(row.Cells[4].Value))
                                    {
                                        Random rnd = new Random();
                                        int itemRnd = rnd.Next(startVal, Convert.ToInt32(row.Cells[6].Value));
                                        writeValue = valueInit + "_" + (itemRnd).ToString();
                                        if (Convert.ToBoolean(row.Cells[2].Value))
                                        {
                                            writeValue = writeValue.PadLeft(Convert.ToInt32(row.Cells[3].Value), '0');
                                        }
                                    }
                                    else
                                    {
                                        writeValue = valueInit + "_" + (startVal + i).ToString();
                                        if (Convert.ToBoolean(row.Cells[2].Value))
                                        {
                                            writeValue = writeValue.PadLeft(Convert.ToInt32(row.Cells[3].Value), '0');
                                        }
                                    }
                                }
                                else
                                {
                                    string[] rangeList = Convert.ToString(row.Cells[7].Value).Split(",");
                                    if (idxRangeLst > rangeList.Length - 1)
                                    {
                                        idxRangeLst = 0;
                                    }

                                    if (string.IsNullOrEmpty(valueInit) || !System.Text.RegularExpressions.Regex.IsMatch(valueInit, "[^0-9]"))
                                    {
                                        writeValue = rangeList[idxRangeLst].ToString().PadLeft(Convert.ToInt32(row.Cells[3].Value), '0');
                                    }
                                    else
                                    {
                                        writeValue = valueInit + rangeList[idxRangeLst];
                                    }
                                }
                                if (!string.IsNullOrEmpty(Convert.ToString(row.Cells[9].Value)) && writeValue.Length > Convert.ToInt32(row.Cells[9].Value))
                                {
                                    MessageBox.Show("-> Độ dài của chuỗi vượt quá [MaxLenght] ở dòng [" + row.Index + 1 + "]", "Lỗi parameter");
                                    sw.Close();
                                    if (File.Exists(Path.Combine(tbxOutputLocation.Text, tbxFilename.Text)))
                                    {
                                        File.Delete(Path.Combine(tbxOutputLocation.Text, tbxFilename.Text));
                                    }
                                    return;
                                }
                                else
                                {
                                    sw.Write(writeValue);
                                }
                                break;
                            case "Date":
                                switch (Convert.ToString(row.Cells[8].Value))
                                {
                                    case "yyyy/MM/dd":
                                        writeValue = 
                                        break;
                                    case "yyyy - MM - dd":
                                        break;
                                    case "yyyyMMdd":
                                        break;
                                    case "yyyy / MM":
                                        break;
                                    case "yyyy - MM":
                                        break;
                                    case "yyyyMM":
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "String":
                                break;
                            default:
                                break;
                        }
                    }
                    sw.Write(sw.NewLine);
                    idxRangeLst++;
                }
                //foreach (DataRow dr in )
                //{
                //    for (int i = 0; i < iColCount; i++)
                //    {
                //        if ((!Convert.IsDBNull(dr[i])) && (i == 7))
                //        {
                //            sw.Write(dr[i].ToString().Replace("\r", " "));
                //        }
                //        else
                //        {
                //            sw.Write(dr[i].ToString().Replace(",", " "));
                //        }

                //        if (i < iColCount - 1)
                //        {
                //            sw.Write(",");
                //        }
                //    }

                //    sw.Write(sw.NewLine);
                //}

                sw.Close();
                //MessageBox.Show("Tạo file CSV thành công", "CSV SUCCESS");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell cell = this.dataGridView1.CurrentCell as DataGridViewCheckBoxCell;

            if (cell != null && !cell.ReadOnly)
            {
                cell.Value = cell.Value == null || !((bool)cell.Value);
                this.dataGridView1.RefreshEdit();
                this.dataGridView1.NotifyCurrentCellDirty(true);

                // PaddingZero
                if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value))
                {
                    enableRow(dataGridView1.Rows[e.RowIndex].Cells[3], true);
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                    enableRow(dataGridView1.Rows[e.RowIndex].Cells[3], false);
                }
            }
        }
    }
}