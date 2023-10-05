using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeckoDotNet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void memViewGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
            /*
            // Does the current cell have a valid address?
            UInt32 bAddress;
            if (GlobalFunctions.tryToHex(memViewGrid.SelectedCells[0].Value.ToString(), out bAddress) && ValidMemory.validAddress(bAddress))
            {
                // Jump memory viewer there
                //memViewAValue.Text = GlobalFunctions.toHex(bAddress);
                CenteredMemViewSelection(sender, e, bAddress);
            }
            */
        }

        private void memViewGrid_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
            /*
            UInt32 bAddress = ValidMemory.ValidAreas[MemViewARange.SelectedIndex].low + (uint)vScrollBarMemViewGrid.Value;
            uint smallChange = (uint)vScrollBarMemViewGrid.SmallChange;
            uint largeChange = (uint)vScrollBarMemViewGrid.LargeChange;

            //UInt32 bAddress = viewer.address;
            int currentRow = memViewGrid.SelectedCells[0].RowIndex, currentCol = memViewGrid.SelectedCells[0].ColumnIndex;
            bool keepSelectedCell = false;

            if (e.KeyCode == Keys.Up)
            {
                // Watch for edge cases; at the top and user presses up, don't change selected cell
                if ((viewer.address & 0xFFFFFFF0) == (viewer.selectedAddress & 0xFFFFFFF0))
                {
                    bAddress -= smallChange;
                }
                else if (e.Shift)
                {
                    bAddress -= smallChange;
                    e.Handled = true;
                }
                else
                {
                    // Otherwise, update the memory viewer or the user won't see the selected cell scrolling up
                    MemView.Update();
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                // at the bottom and user presses down
                if (((viewer.address + 0xF0) & 0xFFFFFFF0) == (viewer.selectedAddress & 0xFFFFFFF0))
                {
                    bAddress += smallChange;
                }
                else if (e.Shift)
                {
                    bAddress += smallChange;
                    e.Handled = true;
                }
                else
                {
                    // Otherwise, update the memory viewer or the user won't see the selected cell scrolling down
                    MemView.Update();
                }
            }

            if (e.KeyCode == Keys.PageUp)
            {
                bAddress -= largeChange;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.PageDown)
            {
                bAddress += largeChange;
                e.Handled = true;
            }

            if (bAddress != viewer.address && ValidMemory.validAddress(bAddress))
            {
                // Jump memory viewer there
                //memViewAValue.Text = GlobalFunctions.toHex(bAddress);
                //MemViewUpdate_Click(sender, e);

                CenteredMemView(sender, e, bAddress);

                //viewer.address = bAddress;
                //viewer.Update();
                //memViewGrid.Update();
            }

            if (e.KeyCode == Keys.Enter)
            {
                // Always prevent the enter key from moving to the next row
                e.Handled = true;
                UInt32 destinationAddress;
                if (GlobalFunctions.tryToHex(memViewGrid.SelectedCells[0].Value.ToString(), out destinationAddress) &&
                    ValidMemory.validAddress(destinationAddress))
                {
                    // Jump memory viewer there
                    CenteredMemViewSelection(sender, e, destinationAddress);
                }
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                if (!e.Shift)
                {
                    // No shift, only copy selected cell
                    Clipboard.SetText(memViewGrid.SelectedCells[0].Value.ToString());
                }
                else
                {
                    Clipboard.SetText(MemoryViewerContentsAsString());
                }
            }
            */
        }

        private String MemoryViewerContentsAsString()
        {
            throw new NotImplementedException();
            /*
            String returnResult = String.Empty;

            foreach (DataGridViewRow gridRow in memViewGrid.Rows)
            {
                foreach (DataGridViewCell rowCell in gridRow.Cells)
                {
                    if (rowCell == memViewGrid.CurrentCell)
                    {
                        returnResult += "*" + rowCell.Value.ToString() + "*";
                    }
                    else
                    {
                        returnResult += rowCell.Value.ToString();
                    }
                    if (rowCell != gridRow.Cells[gridRow.Cells.Count - 1])
                    {
                        // Add a tab to all but the last row cell
                        returnResult += "\t";
                    }
                }
                returnResult += "\r\n";
            }

            return returnResult;
            */
        }

        private void memViewGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex, col = e.ColumnIndex;
            if (col >= 0 && row >= 0 && e.Button == MouseButtons.Right)
            {
                //memViewGrid[col, row].Selected = true;
                memViewGrid.CurrentCell = memViewGrid[col, row];
            }
        }

        private void memViewGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
            /*
            // Avoid processing if the mouse isn't over an actual data cell
            if (e.ColumnIndex < 1) return;
            if (e.RowIndex < 0) return;

            // Figure out what byte the mouse is over
            // The point location in e is relative to the upper left corner
            uint offset;
            if (e.X < 21)
            {
                offset = 0;
            }
            else if (e.X < 35)
            {
                offset = 1;
            }
            else if (e.X < 49)
            {
                offset = 2;
            }
            else
            {
                offset = 3;
            }

            // Change the DataGridView's 0th column's header
            uint hoverAddress = viewer.address;
            hoverAddress += 0x10 * (uint)e.RowIndex;
            hoverAddress += (uint)(e.ColumnIndex - 1) * 4;
            hoverAddress += offset;
            // Pad with some white space so that the cell width doesn't change
            address.HeaderText = GlobalFunctions.toHex(hoverAddress, 8);
            */
        }
        private void memViewSetBP_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            uint byteOffset;
            GlobalFunctions.tryToHex(address.HeaderText.Trim(), out byteOffset);
            BPAddress.Text = GlobalFunctions.toHex(viewer.selectedAddress + (byteOffset & 0x3));

            // If the current BPType is Execute, change to Read/Write
            if (BPType.SelectedIndex == 3)
            {
                BPType.SelectedIndex = 2;
            }
            MainControl.SelectedTab = BreakpointPage;
            */
        }

        private void memViewAddToWatch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            UInt32 vAdd = viewer.selectedAddress;
            watcher.AddWatch(GlobalFunctions.toHex(vAdd), new UInt32[] { vAdd }, WatchDataSize.Bit32);
            MainControl.SelectedTab = WatchTab;
            */
        }

        private void memViewAddGCTCode_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            try
            {
                UInt32 vAdd = viewer.selectedAddress;
                UInt32 cRegion = vAdd & 0xFE000000;
                UInt32 value = gecko.peek(vAdd);
                vAdd = vAdd - cRegion + 0x04000000;
                int nCodeId = GCTCodeContents.Count;

                String name;
                if (!InputBox.Show("Code name", "Insert code name", "New code", out name))
                {
                    name = "New code " + (nCodeId + 1).ToString();
                }
                CodeContent nCode = new CodeContent();
                bool addlines = false;
                if (cRegion != 0x80000000)
                {
                    addlines = true;
                    nCode.addLine(0x42000000, cRegion);
                }
                nCode.addLine(vAdd, value);
                if (addlines)
                    nCode.addLine(0xE0000000, 0x80008000);

                GCTCodeContents.AddCode(nCode, name);
                MainControl.SelectedTab = GCTPage;
            }
            catch (EUSBGeckoException exc)
            {
                exceptionHandling.HandleException(exc);
            }
            */
        }

        private void memViewUpload_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (openBinary.ShowDialog() == DialogResult.OK)
            {
                UInt32 vAdd = viewer.selectedAddress;
                FileStream fs = new FileStream(openBinary.FileName, FileMode.Open, FileAccess.Read);
                fs.Position = 0;
                UInt32 endAdd = vAdd + (UInt32)fs.Length;
                if (!ValidMemory.validAddress(endAdd))
                {
                    MessageBox.Show("File too large to be uploaded to this address!");
                    fs.Close();
                    return;
                }
                try
                {
                    gecko.Upload(vAdd, endAdd, fs);
                }
                catch (EUSBGeckoException exc)
                {
                    exceptionHandling.HandleException(exc);
                }
                fs.Close();
            }
            */
        }

        private void MemViewSearchPerfom_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (viewer.Searching)
            {
                // Let the user cancel the search by pressing the button again
                viewer.Searching = false;
                return;
            }

            String sString = MemViewSearchString.Text;
            bool hex = MemViewSearchType.SelectedIndex == 4;
            bool caseSensitive = (MemViewSearchType.SelectedIndex % 2 == 1) || hex;
            bool unicode = (MemViewSearchType.SelectedIndex >= 2);

            byte[] stringBytes;
            if (unicode)
            {
                stringBytes = Encoding.Unicode.GetBytes(sString);
            }
            else
            {
                stringBytes = Encoding.ASCII.GetBytes(sString);
            }

            if (hex)
            {
                sString = System.Text.RegularExpressions.Regex.Replace(sString.ToUpper(), "[^0-9A-F]", String.Empty);
                if (!GlobalFunctions.tryToHex(sString, out stringBytes))
                {
                    return;
                }
            }

            viewer.Searching = true;
            MemViewSearchPerfom.Text = "Cancel";
            viewer.SearchString(stringBytes, caseSensitive, unicode, hex);  // Synchronous, but pumps messages!
            viewer.Searching = false;
            MemViewSearchPerfom.Text = "Search";
            CenteredMemViewSelection(sender, e, viewer.address);
            */
        }

        private void gCTWizardToolStripMenuItemMemView_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            int indexToSelect = GCTCodeContents.Count;  // will pick "New Code"
            bool wasSelected = false;
            if (GCTCodeList.SelectedItems.Count != 0)
            {
                // If there is a selected code in the GCT Code List, pick it instead
                indexToSelect = GCTCodeList.SelectedIndices[0];
                wasSelected = true;
            }

            if (GCTCodeList.SelectedItems.Count > 0)
            {
                // Must de-select current item before changing it
                GCTCodeList.SelectedItems[0].Selected = false;
            }

            UInt32 vAdd = viewer.selectedAddress;
            UInt32 value = gecko.peek(vAdd);

            codeWizard.textBoxAddress.Text = GlobalFunctions.toHex(vAdd);
            codeWizard.textBoxValue.Text = GlobalFunctions.toHex(value);

            codeWizard.comboBoxCodeType.SelectedIndex = 0;

            codeWizard.radioButton32Bit.Checked = true;

            codeWizard.PrepareGCTWizard(indexToSelect);
            DialogResult dialogResult = codeWizard.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
            }

            if (wasSelected)
            {
                GCTCodeList.Items[indexToSelect].Selected = true;
            }
            */
        }

        private void disassemblerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            DisRegion.Text = GlobalFunctions.toHex(viewer.selectedAddress);

            DisUpdateBtn_Click(sender, e);

            MainControl.SelectedTab = DisPage;
            */
        }
    }
}
