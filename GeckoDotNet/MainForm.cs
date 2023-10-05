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

        private void copySelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Send ctrl+c
            memViewGrid_KeyDown(sender, new KeyEventArgs(Keys.C | Keys.Control));
            //SendKeys.Send("^C");
            //SendKeys.Flush();
            //Application.DoEvents();
        }

        private void copyAllCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Send ctrl+shift+c
            memViewGrid_KeyDown(sender, new KeyEventArgs(Keys.C | Keys.Control | Keys.Shift));
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            CodeContent code = GCTCodeContents[GCTCodeList.SelectedIndices[0]];
            CodeContent commentedCode = new CodeContent();
            for (int i = 0; i < code.lines.Count; i++)
            {
                commentedCode.addLine(code.lines[i].left, code.lines[i].right, false);
            }

            GCTCodeValues.Text = CodeController.CodeContentToCodeTextBox(commentedCode);
            */
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            CodeContent code = GCTCodeContents[GCTCodeList.SelectedIndices[0]];
            CodeContent uncommentedCode = new CodeContent();
            for (int i = 0; i < code.lines.Count; i++)
            {
                uncommentedCode.addLine(code.lines[i].left, code.lines[i].right, true);
            }

            GCTCodeValues.Text = CodeController.CodeContentToCodeTextBox(uncommentedCode);
            */
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.SendKeyCode(new KeyEventArgs(Keys.Control | Keys.Enter));
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.SendKeyCode(new KeyEventArgs(Keys.Control | Keys.Delete));
            }
        }

        private void clearAllHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.SendKeyCode(new KeyEventArgs(Keys.Control | Keys.Shift | Keys.Delete));
            }
        }

        private void cutAllHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.SendKeyCode(new KeyEventArgs(Keys.Control | Keys.Shift | Keys.X));
            }
        }

        private void copyAllHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.SendKeyCode(new KeyEventArgs(Keys.Control | Keys.Shift | Keys.C));
            }
        }

        private void pasteAllHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.SendKeyCode(new KeyEventArgs(Keys.Control | Keys.Shift | Keys.V));
            }
        }

        private void autoHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.AutoHistory = !addressBox.AutoHistory;
            }
        }

        private void addressContextMenu_Opened(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            HistoryTextBox historyBox = GetHistoryBoxFromSender(sender);
            if (addressBox != null)
            {
                autoHistoryToolStripMenuItem.Checked = addressBox.AutoHistory;
                AddressContextMenuOwner = addressBox;
                HistoryContextMenuOwner = null;
            }
            else if (historyBox != null)
            {
                autoHistoryToolStripMenuItem.Checked = historyBox.AutoHistory;
                AddressContextMenuOwner = null;
                HistoryContextMenuOwner = historyBox;
            }
            */
        }

        private AddressTextBox GetAddressBoxFromSender(object sender)
        {
            //Make sure the sender is a ToolStripMenuItem
            ToolStripMenuItem myItem = sender as ToolStripMenuItem;

            // If that fails, the sender might actually be a ContextMenuStrip already
            // This is the case when called from ContextMenuStrip_Opened
            if (myItem == null)
            {
                //Get the ContextMenuString (owner of the ToolsStripMenuItem)
                ContextMenuStrip theStrip = sender as ContextMenuStrip;
                if (theStrip != null)
                {
                    return theStrip.SourceControl as AddressTextBox;
                }
            }

            // If it didn't fail, get the ContextMenuStrip out of it
            if (myItem != null)
            {
                ContextMenuStrip theStrip = myItem.Owner as ContextMenuStrip;
                if (theStrip != null)
                {
                    return theStrip.SourceControl as AddressTextBox;
                }
            }

            // If above casts fail, return nothing
            return null;
        }

        private HistoryTextBox GetHistoryBoxFromSender(object sender)
        {
            //Make sure the sender is a ToolStripMenuItem
            ToolStripMenuItem myItem = sender as ToolStripMenuItem;

            // If that fails, the sender might actually be a ContextMenuStrip already
            // This is the case when called from ContextMenuStrip_Opened
            if (myItem == null)
            {
                //Get the ContextMenuString (owner of the ToolsStripMenuItem)
                ContextMenuStrip theStrip = sender as ContextMenuStrip;
                if (theStrip != null)
                {
                    return theStrip.SourceControl as HistoryTextBox;
                }
            }

            // If it didn't fail, get the ContextMenuStrip out of it
            if (myItem != null)
            {
                ContextMenuStrip theStrip = myItem.Owner as ContextMenuStrip;
                if (theStrip != null)
                {
                    return theStrip.SourceControl as HistoryTextBox;
                }
            }

            // If above casts fail, return nothing
            return null;
        }

        private void showHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressTextBox addressBox = GetAddressBoxFromSender(sender);
            if (addressBox != null)
            {
                addressBox.ShowHistory(true);
            }
        }

        private void BPConditionRegSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBPCondValue();
        }

        private void UpdateBPCondValue()
        {
            throw new NotImplementedException();
            /*
            BPCondValue.Text = GlobalFunctions.toHex(bpHandler.GetRegisterValue(BPConditionRegSelect.SelectedIndex));
            */
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (AddressContextMenuOwner != null)
                Clipboard.SetText(AddressContextMenuOwner.Text);
            else if (HistoryContextMenuOwner != null)
                Clipboard.SetText(HistoryContextMenuOwner.Text);
            */
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (AddressContextMenuOwner != null)
                AddressContextMenuOwner.Text = Clipboard.GetText();
            else if (HistoryContextMenuOwner != null)
                HistoryContextMenuOwner.Text = Clipboard.GetText();
            */
        }

        private void MemViewScrollbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown)
            {
                MemViewScrollbar.Value = 0;
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                MemViewScrollbar.Value = 2;
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BPCondDel_Click(sender, e);
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BPCondClear_Click(sender, e);
        }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string clipboardText = String.Empty;
            foreach (string cond in BPCondList.Items)
            {
                clipboardText += cond.ToString() + "\r\n";
            }
            Clipboard.SetText(clipboardText);
        }

        private void SRR0NEQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            int reg = (int)GeckoApp.BPList.RegisterList.SRR0;
            BreakpointCondition cond = new BreakpointCondition(
                reg, bpHandler.GetRegisterValue(reg), BreakpointComparison.NotEqual);

            bpHandler.conditions.Add(cond);
            */
        }

        private void SRR0EQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            int reg = (int)GeckoApp.BPList.RegisterList.SRR0;
            BreakpointCondition cond = new BreakpointCondition(
                 reg, bpHandler.GetRegisterValue(reg), BreakpointComparison.Equal);

            bpHandler.conditions.Add(cond);
            */
        }

        private void copyToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string clipboardText = String.Empty;
            foreach (string asm in DisAssBox.Items)
            {
                clipboardText += asm.ToString() + "\r\n";
            }
            Clipboard.SetText(clipboardText);
        }

        private void BPCondList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BPCondDel_Click(sender, e);
                e.Handled = true;
            }
        }

        private void AsText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Assemble_Click(sender, e);
            }
        }

        private void SetConditionGroupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (e.KeyCode == Keys.Enter)
            {
                List<int> indices = new List<int>();
                for (int i = BPCondList.SelectedItems.Count - 1; i >= 0; i--)
                {
                    indices.Add(BPCondList.SelectedIndices[i]);
                }

                foreach (int index in indices)
                {
                    bpHandler.conditions.SetIndexedConditionGroup(index, Convert.ToUInt32(SetConditionGroupTextBox.Text));
                }
                BPCondMenu.Hide();
            }
            */
        }

        private void BPCondMenu_Opened(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            int index = BPCondList.SelectedIndex;
            String newText;

            if (index == -1)
            {
                newText = "1";
            }
            else
            {
                newText = bpHandler.conditions.GetIndexedConditionGroup(BPCondList.SelectedIndex).ToString();
            }
            SetConditionGroupTextBox.Text = newText;
            */
        }

        private void SetConditionGroupTextBox_TextChanged(object sender, EventArgs e)
        {
            String text = SetConditionGroupTextBox.Text;
            text = System.Text.RegularExpressions.Regex.Replace(text, "[^0-9]", String.Empty);
            SetConditionGroupTextBox.Text = text;
        }

        private void setConditionGroupToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            SetConditionGroupTextBox.Focus();
            SetConditionGroupTextBox.SelectAll();
        }

        private void BPCondList_MouseDown(object sender, MouseEventArgs e)
        {
            int index = BPCondList.IndexFromPoint(e.Location);
            if (e.Button == MouseButtons.Right && !BPCondList.SelectedIndices.Contains(index))
            {
                BPCondList.ClearSelected();
                BPCondList.SelectedIndex = index;
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            String[] sep = Clipboard.GetText().Split(new char[] { '\r', '\n' });
            foreach (String entry in sep)
            {
                BreakpointCondition cond = BreakpointCondition.FromString(entry);
                if (cond != null)
                {
                    bpHandler.conditions.Add(cond);
                }
            }
            */
        }

        private void copyToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string clipboardText = String.Empty;
            foreach (string cond in BPCondList.SelectedItems)
            {
                clipboardText += cond.ToString() + "\r\n";
            }
            Clipboard.SetText(clipboardText);
        }

        private void buttonStepUntil_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (SteppingUntil)
            {
                SteppingUntil = false;
                buttonStepUntil.Text = "Step until";
                return;
            }

            try
            {
                if (gecko.status() == WiiStatus.Breakpoint)
                {
                    SteppingUntil = true;
                    buttonStepUntil.Text = "Cancel";
                    // Repeatedly Step Into until the conditions are matched
                    MemoryStream regStream = new MemoryStream();
                    gecko.GetRegisters(regStream);

                    while (!bpHandler.conditions.Check(regStream, BreakpointType.Step, 0, gecko) && SteppingUntil)
                    {
                        BPStepButton_Click(sender, e);
                        System.Threading.Thread.Sleep(100);
                        MainControl.Update();
                        regStream.Seek(0, SeekOrigin.Begin);
                        regStream.SetLength(0);
                        gecko.GetRegisters(regStream);
                        Application.DoEvents();
                    }
                    SteppingUntil = false;
                    checkBoxBPCondEnable.Checked = false;
                    buttonStepUntil.Text = "Step until";
                }
            }
            catch (EUSBGeckoException exc)
            {
                exceptionHandling.HandleException(exc);
                SteppingUntil = false;
                buttonStepUntil_Click(sender, e);
            }
            */
        }

        private void checkBoxBPCondEnable_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            bpHandler.conditions.Enabled = checkBoxBPCondEnable.Checked;
            */
        }

        private void checkBoxLogSteps_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (BPStepLogWriter != null)
            {
                BPStepLogWriter.Close();
                BPStepLogWriter.Dispose();
                BPStepLogWriter = null;
            }

            if (checkBoxLogSteps.Checked)
            {
                DialogResult SaveFileResult = saveFileDialogLogSteps.ShowDialog();
                if (SaveFileResult == DialogResult.OK)
                {
                    BPStepLogWriter = new StreamWriter(saveFileDialogLogSteps.FileName, true);
                    BPStepLogWriter.WriteLine();
                    BPStepLogWriter.WriteLine();
                }
                else
                {
                    checkBoxLogSteps.Checked = false;
                }
            }
            */
        }

        private void buttonUndoSearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            DialogResult confirmationPrompt = MessageBox.Show("Are you sure you want to undo?", "Confirm Undo", MessageBoxButtons.OKCancel);
            if (confirmationPrompt == DialogResult.OK)
            {
                search.UndoSearch();
            }

            buttonUndoSearch.Enabled = search.CanUndo();
            */
        }

        private void numericUpDownNewSearchIndex_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (numericUpDownNewSearchIndex.Value > search.DumpNum)
            {
                numericUpDownNewSearchIndex.Value = search.DumpNum;
            }
            else if (numericUpDownNewSearchIndex.Value != 0)
            {
                search.LoadIndexIntoNewSearchDump(Convert.ToInt32(numericUpDownNewSearchIndex.Value));
                search.LoadIndexIntoSearchList(Convert.ToInt32(numericUpDownNewSearchIndex.Value));
                search.UpdateGridViewPage(false);
            }
            UpdateValueTypeDropDown();
            */
        }


        private void numericUpDownOldSearchIndex_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (numericUpDownOldSearchIndex.Value > search.DumpNum - 1)
            {
                if (search.DumpNum == 0)
                {
                    numericUpDownOldSearchIndex.Value = 0;
                }
                else
                {
                    numericUpDownOldSearchIndex.Value = search.DumpNum - 1;
                }
            }
            else if (numericUpDownOldSearchIndex.Value != 0)
            {
                search.LoadIndexIntoOldSearchDump(Convert.ToInt32(numericUpDownOldSearchIndex.Value));
                search.UpdateGridViewPage(false);
            }
            UpdateValueTypeDropDown();
            */
        }

        private void buttonAddSearchGroup_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            UInt32 lValue;
            if (!GlobalFunctions.tryToHex(textBoxComparisonValue.Text, out lValue))
            {
                lValue = 0;
            }

            searchComparisons.Add(new SearchComparisonInfo(GetCmpType(), lValue, GetCmpRHS()));
            SearchGroupIndex = searchComparisons.Count - 1;
            groupBoxSearchGroups.Text = "Search Groups (" + searchComparisons.Count + ")";
            */
        }

        private int SearchGroupIndex
        {
            get
            {
                return Convert.ToInt32(numericUpDownSearchGroup.Value) - 1;
            }
            set
            {
                numericUpDownSearchGroup.Value = value + 1;
            }
        }
        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (searchComparisons.Count > 1)
            {
                searchComparisons.RemoveAt(SearchGroupIndex);
            }
            if (SearchGroupIndex >= searchComparisons.Count)
            {
                SearchGroupIndex = searchComparisons.Count - 1;
            }
            groupBoxSearchGroups.Text = "Search Groups (" + searchComparisons.Count + ")";
            */
        }

        private void buttonClearSearchGroup_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            while (searchComparisons.Count > 1)
            {
                searchComparisons.RemoveAt(1);
            }
            SearchGroupIndex = 0;
            groupBoxSearchGroups.Text = "Search Groups (" + searchComparisons.Count + ")";
            */
        }

        private void lowerValue_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            UInt32 value;
            if (GlobalFunctions.tryToHex(textBoxComparisonValue.Text, out value))
            {
                searchComparisons[SearchGroupIndex].value = value;
            }
            */
        }

        private void numericUpDownSearchGroup_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            Int32 value = SearchGroupIndex;
            if (value >= searchComparisons.Count)
            {
                SearchGroupIndex = searchComparisons.Count - 1;
                return;
            }
            SearchComparisonInfo comp = searchComparisons[value];
            SetCmpRHS(comp.searchType);
            SetCmpType(comp.comparisonType);
            textBoxComparisonValue.Text = GlobalFunctions.toHex(comp.value);
            */
        }

        private void GCTCodeValues_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                GCTCodeValues.SelectAll();
            }
        }

        private void setSRR0HereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            bpHandler.SetSRR0(disassembler.disAddress);
            MainControl.SelectedTab = BreakpointPage;
            */
        }

        private void ShowMemContextMenu_Opening(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (ValidMemory.validAddress(bpHandler.MemoryAddress))
            {
                toolStripTextBoxShowMemAddress.Text = GlobalFunctions.toHex(bpHandler.MemoryAddress);
                toolStripTextBoxShowMemValue.Text = GlobalFunctions.toHex(gecko.peek(bpHandler.MemoryAddress));
            }
            else
            {
                toolStripTextBoxShowMemAddress.Text = "00000000";
                toolStripTextBoxShowMemValue.Text = "00000000";
                //e.Cancel = true;
            }
            */
        }

        private void ShowMemAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(toolStripTextBoxShowMemAddress.Text);
        }

        private void ShowMemValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(toolStripTextBoxShowMemValue.Text);
        }

        // Scrolls a given textbox. handle: an handle to our textbox. pixles: 
        // number of pixels to scroll.
        public void ScrollBPDissToLine(int line)
        {
            //ScrollInfo foo = new ScrollInfo();
            //foo.fMask = SIF_POS;
            //foo.nPos = 10*line;
            //SetScrollInfo(richTextBox1.Handle, SIF_POS, ref foo, true);
            //SendMessage(richTextBox1.Handle, WM_VSCROLL, 
        }

        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        private const int SB_LINELEFT = 0;
        private const int SB_LINERIGHT = 1;
        private const int SB_PAGELEFT = 2;
        private const int SB_PAGERIGHT = 3;
        private const int SB_THUMBPOSITION = 4;
        private const int SB_THUMBTRACK = 5;
        private const int SB_LEFT = 6;
        private const int SB_RIGHT = 7;
        private const int SB_ENDSCROLL = 8;

        private const int SIF_TRACKPOS = 0x10;
        private const int SIF_RANGE = 0x1;
        private const int SIF_POS = 0x4;
        private const int SIF_PAGE = 0x2;
        private const int SIF_ALL = SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS;

        private void walkToBlrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            WalkToBLR();
            */
        }

        private void stackFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            uint LRSaveWord = 0;
            uint nextFramePointer = bpHandler.GetRegisterValue((int)GeckoApp.BPList.RegisterList.r1);
            ParseStackFrame(nextFramePointer, out LRSaveWord, ref nextFramePointer);

            try
            {
                if (LRSaveWord != 0)
                {
                    if (bpHandler.SetBreakpoint(LRSaveWord, BreakpointType.Execute, true))
                    {
                        BPMode(true);
                    }
                    bpHandler.DecIndent();  // account for the bl we're skipping over
                }
            }
            catch (EUSBGeckoException exc)
            {
                exceptionHandling.HandleException(exc);
            }
            */
        }

        private void leafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            try
            {
                if (gecko.status() == WiiStatus.Breakpoint)
                {
                    if (bpHandler.SetBreakpoint(bpHandler.GetRegisterValue((int)GeckoApp.BPList.RegisterList.LR), BreakpointType.Execute, true))
                    {
                        BPMode(true);
                    }
                    bpHandler.DecIndent();  // account for the bl we're skipping over
                }
            }
            catch (EUSBGeckoException exc)
            {
                exceptionHandling.HandleException(exc);
            }
            */
        }

        private void buttonDisassemblySearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (SearchingDisassembly)
            {
                SearchingDisassembly = false;
                return;
            }
            uint searchStartAddress;
            if (!AsAddress.IsValidGet(out searchStartAddress))
            {
                MessageBox.Show("Start address fail!");
                return;
            }

            if (textBoxDisassemblySearch.Text == String.Empty)
            {
                MessageBox.Show("Regex fail!");
                return;
            }

            string searchString = textBoxDisassemblySearch.Text;

            if (!checkBoxRegexSearch.Checked)
            {
                searchString = System.Text.RegularExpressions.Regex.Escape(searchString);
            }

            SearchingDisassembly = true;
            buttonDisassemblySearch.Text = "Cancel";


            //UInt32 bAddress = RecursivePromptDisassemblySearch(searchStartAddress, radioButtonSearchDisassemblyDown.Checked,
            //searchString, 16256);   // should be one full packet of dump
            UInt32 bAddress;
            UInt32 searchStartAddressCopy = searchStartAddress;
            bool searchDown = radioButtonSearchDisassemblyDown.Checked;
            do
            {
                bAddress = FindRegexAddressInDisassembly(ref searchStartAddressCopy, searchDown, searchString, 0xFE00 / 4 * 2);
            } while (bAddress == 0 && SearchingDisassembly && searchStartAddressCopy != 0x817FFFFC && searchStartAddressCopy != 0x80000000);




            if (bAddress != 0)
            {
                // Found something!  Go there
                disassembler.DissToBox(bAddress);
            }
            else
            {
                if (SearchingDisassembly)
                    MessageBox.Show("Could not find search query");
            }

            SearchingDisassembly = false;
            buttonDisassemblySearch.Text = "Search";
            */
        }

        private void buttonSerialPoke_Click(object sender, EventArgs e)
        {
            // Poke
            PButton_Click(sender, e);
            //            Application.DoEvents();
            // Get next address
            PAddress.ShowHistory(true);
            PAddress.SendKeyCode(new KeyEventArgs(Keys.Down));
            //            Application.DoEvents();
            // Commit and hide the history
            PAddress.SendKeyCode(new KeyEventArgs(Keys.Enter));
        }

        private void copyFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            uint searchStartAddress;
            if (!AsAddress.IsValidGet(out searchStartAddress))
            {
                MessageBox.Show("Start address fail!");
                return;
            }

            uint prologueAddress = GetFunctionStartAddress(searchStartAddress);
            uint epilogueAddress = GetFunctionEndAddress(searchStartAddress);

            int count = (int)(epilogueAddress - prologueAddress) + 4;
            count /= 4;

            String[] searchDisassemblyStrings = disassembler.Disassemble(prologueAddress, count);

            String BigDisassemblyString = String.Empty;

            foreach (string line in searchDisassemblyStrings)
            {
                BigDisassemblyString += line + "\r\n";
            }

            Clipboard.SetText(BigDisassemblyString);
            */
        }

        private void toolStripTextBoxShowMemValue_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (e.KeyCode == Keys.Enter && !e.Control)
            {
                e.Handled = true;
                uint address, value;
                if (GlobalFunctions.tryToHex(toolStripTextBoxShowMemAddress.Text, out address) &&
                    ValidMemory.validAddress(address) &&
                    GlobalFunctions.tryToHex(toolStripTextBoxShowMemValue.Text, out value))
                {
                    gecko.poke(address, value);
                }
            }
            */
        }

        private void ChangeMemViewFontSize(float newSize)
        {
            foreach (DataGridViewRow row in memViewGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Font newFont = null;
                    if (cell.Style.Font != null)
                    {
                        newFont = new Font(cell.Style.Font.FontFamily, newSize);
                    }
                    else if (cell.InheritedStyle.Font != null)
                    {
                        newFont = new Font(cell.InheritedStyle.Font.FontFamily, newSize);
                    }

                    if (newFont != null)
                    {
                        cell.Style.Font = newFont;
                    }
                }
            }


            //Font newRowTemplateFont = new Font(memViewGrid.RowTemplate.DefaultCellStyle.Font.FontFamily, newSize);


            //Font newColumnHeaderFont = new Font(memViewGrid.ColumnHeadersDefaultCellStyle.Font.FontFamily, newSize);


            Font newColumnHeaderFont = new Font(memViewGrid.ColumnHeadersDefaultCellStyle.Font.FontFamily, newSize);


            //memViewGrid.RowTemplate.DefaultCellStyle.Font = newRowTemplateFont;
            memViewGrid.ColumnHeadersDefaultCellStyle.Font = newColumnHeaderFont;
        }

        private void toolStripTextBoxMemViewFontSize_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float casted = Convert.ToSingle(toolStripTextBoxMemViewFontSize.Text);
                    ChangeMemViewFontSize(casted);
                    GeckoApp.Properties.Settings.Default.MemViewFontSize = casted;
                    GeckoApp.Properties.Settings.Default.Save();
                    memViewContextMenu.Close();
                }
                catch (FormatException)
                {
                    toolStripTextBoxMemViewFontSize.Text = (10).ToString();
                }
            }
            */
        }

        private void fontSizeToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTextBoxMemViewFontSize.Focus();
            toolStripTextBoxMemViewFontSize.SelectAll();
        }

        private void viewFloatsInHexToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            bpHandler.ShowFloatsInHex = viewFloatsInHexToolStripMenuItem.Checked;
            GeckoApp.Properties.Settings.Default.ViewFloatsInHex = viewFloatsInHexToolStripMenuItem.Checked;
            GeckoApp.Properties.Settings.Default.Save
            */
        }

        private void IntelligentStepOut()
        {
            if (IsLeafFunction() != 0)
            {
                leafToolStripMenuItem_Click(null, null);
            }
            else
            {
                stackFrameToolStripMenuItem_Click(null, null);
            }
        }

        private uint IsLeafFunction()
        {
            throw new NotImplementedException();
            /*
            try
            {
                if (gecko.status() == WiiStatus.Breakpoint)
                {
                    // Get the LR and current address and its ASM
                    uint potentialBLAddress = bpHandler.GetRegisterValue((int)GeckoApp.BPList.RegisterList.LR) - 4;
                    uint currentAddress = bpHandler.GetRegisterValue((int)GeckoApp.BPList.RegisterList.SRR0);
                    string[] asmArray = disassembler.Disassemble(potentialBLAddress, 1);
                    string asm = string.Empty;
                    if (asmArray.Length > 0) asm = asmArray[0];
                    uint potentialStartAddress = 0;

                    // Is it a bl?
                    if (System.Text.RegularExpressions.Regex.Match(asm, "bl\\t0x").Success)
                    {
                        int addressIndex = asm.LastIndexOf("bl\t0x") + 5;

                        // Is it valid?
                        if (GlobalFunctions.tryToHex(asm.Substring(addressIndex), out potentialStartAddress) &&
                            ValidMemory.validAddress(potentialStartAddress))
                        {
                            uint startAddressCopy = potentialStartAddress;
                            // Find the ending blr|b..lr (TODO: if we're after a b..lr but in a leaf, it will accidentally do a stack walk)
                            uint potentialEndAddress = RecursivePromptDisassemblySearch(potentialStartAddress, true, "^(blr|b..lr)", 5000);
                            int range = (int)(potentialEndAddress - potentialStartAddress + 10);

                            // If we are in between the start and end, inclusive, and there's no stwu r1 to create a stack frame (guards against recursion)
                            // Then we are a leaf function
                            if (currentAddress >= potentialStartAddress && currentAddress <= potentialEndAddress &&
                                FindRegexAddressInDisassembly(ref startAddressCopy, true, "stwu r1,", range) == 0)
                            {
                                return potentialBLAddress + 4;
                            }
                        }
                    }
                }
            }
            catch (EUSBGeckoException exc)
            {
                exceptionHandling.HandleException(exc);
            }

            return 0;
            */
        }

        private void buttonStepOutOf_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (SteppingOut)
            {
                SteppingOut = false;
                buttonStepOutOf.Text = "Step out";
                return;
            }

            IntelligentStepOut();
            */
        }

        private void listBoxCallStack_DoubleClick(object sender, EventArgs e)
        {
            uint disasmAddress = 0;
            if (listBoxCallStack.Items.Count == 0)
            {
                LoadCallStack();
                return;
            }
            if (GlobalFunctions.tryToHex(listBoxCallStack.SelectedItem.ToString(), out disasmAddress))
            {
                if (ValidMemory.validAddress(disasmAddress))
                {
                    DisRegion.Text = listBoxCallStack.SelectedItem.ToString();

                    DisUpdateBtn_Click(sender, e);
                }
            }
        }

        private void LoadCallStack()
        {
            throw new NotImplementedException();
            /*
            if (gecko.status() == WiiStatus.Breakpoint)
            {
                listBoxCallStack.Items.Clear();
                listBoxCallStack.Items.Add("Loading call stack...");
                List<uint> callStack = GetBreakpointCallStack();
                listBoxCallStack.Items.Clear();
                foreach (uint address in callStack)
                {
                    string Hex = String.Format("{0:X}", address);
                    listBoxCallStack.Items.Add(Hex);
                }
            }
            else
            {
                MessageBox.Show("Must be in a breakpoint to show call stack");
            }
            */
        }

        private void gotoFunctionStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            uint startAddress;
            if (GlobalFunctions.tryToHex(AsAddress.Text, out startAddress))
            {
                if (ValidMemory.validAddress(startAddress))
                {
                    startAddress = GetFunctionStartAddress(startAddress);
                    if (ValidMemory.validAddress(startAddress))
                    {
                        DisRegion.Text = String.Format("{0:X}", startAddress);

                        DisUpdateBtn_Click(sender, e);
                    }
                }
            }
            */
        }

        private void gotoFunctionEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            uint startAddress;
            if (GlobalFunctions.tryToHex(AsAddress.Text, out startAddress))
            {
                if (ValidMemory.validAddress(startAddress))
                {
                    startAddress = GetFunctionEndAddress(startAddress);
                    if (ValidMemory.validAddress(startAddress))
                    {
                        DisRegion.Text = String.Format("{0:X}", startAddress - 0x40);

                        DisUpdateBtn_Click(sender, e);

                        DisAssBox.SelectedIndex = 0x10;
                    }
                }
            }
            */
        }

        private void copyToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBoxCallStack.SelectedItem.ToString());
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clipboard = String.Empty;
            foreach (object item in listBoxCallStack.Items)
            {
                clipboard += item.ToString() + "\r\n";
            }
            Clipboard.SetText(clipboard);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCallStack();
        }

        private void convertASCIIToHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void convertHexToASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void jumpToOffsetToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTextBoxMemViewOffset.Focus();
            toolStripTextBoxMemViewOffset.SelectAll();
        }

        private void toolStripTextBoxMemViewOffset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //try
                //{
                //    bool negative = false;
                //    if (toolStripTextBoxMemViewOffset.Text.Contains("-"))
                //    {
                //        toolStripTextBoxMemViewOffset.Text = toolStripTextBoxMemViewOffset.Text.Replace("-", String.Empty);
                //        negative = true;
                //    }
                //    uint casted = Convert.ToUInt32(toolStripTextBoxMemViewOffset.Text, 16);
                //    // get current memview addr, add casted to it, set memview addr

                //    uint address = Convert.ToUInt32(memViewAValue.Text, 16);
                //    address = negative ? address - casted : address + casted;
                //    memViewAValue.Text = String.Format("{0:X}", address);
                //    CenteredMemViewSelection(sender, e, address);
                //    //viewer.address = address;
                //    //viewer.Update();
                //    memViewContextMenu.Close();
                //}
                //catch (FormatException)
                //{
                //}
                memViewAValue.AddOffsetToAddress(toolStripTextBoxAddressAddOffset.Text);
                MemViewUpdate_Click(sender, e);
                memViewContextMenu.Close();
                toolStripTextBoxMemViewOffset.Text = (0).ToString();
            }
        }

        private void addOffsetToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTextBoxAddressAddOffset.Focus();
            toolStripTextBoxAddressAddOffset.SelectAll();
        }

        private void toolStripTextBoxAddressAddOffset_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (e.KeyCode == Keys.Enter)
            {
                if (AddressContextMenuOwner != null)
                    AddressContextMenuOwner.AddOffsetToAddress(toolStripTextBoxAddressAddOffset.Text);
                HistoryContextMenu.Close();
                toolStripTextBoxAddressAddOffset.Text = (0).ToString();
            }
            */
        }

        private void MEM2UpperBoundary_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MEM2UpperBoundary.SelectedIndex)
            {
                case 1:
                    ValidMemory.setMEM2Upper(0x93800000);
                    return;
                case 2:
                    ValidMemory.setMEM2Upper(0x93C00000);
                    return;
                case 3:
                    ValidMemory.setMEM2Upper(0x94000000);
                    return;
                default:
                    ValidMemory.setMEM2Upper(0x93400000);
                    return;
            }

        }
        private void MainControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            throw new NotImplementedException();
            /*
            // If there's a breakpoint pending, keep the breakpoints tab up
            // Note that we're hooking the Selecting event, because this fires before the tab is actually switched
            // If you hook SelectedIndexChanged (the default) then you'll see the other tabs load...
            // ...which causes things like MemoryViewer.Update() to be called if you switch to the Memory Viewer tab
            // which will crash the USB Gecko, but a reconnect fixes that
            //if (BPCancel.Enabled)
            //{
            //    MainControl.SelectedTab = BreakpointPage;
            //}

            //if (buttonCancelSearch.Enabled)
            //{
            //    MainControl.SelectedTab = searchPage;
            //}

            if (TabLock != null)
            {
                MainControl.SelectedTab = TabLock;
            }
            */
        }

        private void Search_Click(object sender, EventArgs e)
        { 
            throw new NotImplementedException();
            /*
            SearchSize size;
            SearchType type;
            ComparisonType cType;
            bool enableUpper;
            bool useDifference;

            switch (comboBoxSearchDataType.SelectedIndex)
            {
                case 0: size = SearchSize.Bit8; break;
                case 1: size = SearchSize.Bit16; break;
                case 2: size = SearchSize.Bit32; break;
                case 3: size = SearchSize.Single; break;
                default: size = SearchSize.Bit32; break;
            }

            switch (comboBoxComparisonRHS.SelectedIndex)
            {
                case 3: type = SearchType.Diff; break;
                case 2: type = SearchType.Old; break;
                case 1: type = SearchType.Unknown; break;
                default: type = SearchType.Exact; break;
            }

            //enableUpper = UpperEnable.SelectedIndex == 1;

            cType = GetCmpType();

            useDifference = (cType == ComparisonType.DifferentBy ||
                             cType == ComparisonType.DifferentByLess ||
                             cType == ComparisonType.DifferentByMore);

            UInt32 lAddress = 0;
            UInt32 hAddress = 0;
            UInt32 lValue = 0;
            UInt32 hValue = 0;
            UInt32 diffBy = 0;

            // Validate inputs
            if (!GlobalFunctions.tryToHex(memStart.Text, out lAddress))
            {
                MessageBox.Show("Start address invalid!");
                return;
            }

            if (!GlobalFunctions.tryToHex(memEnd.Text, out hAddress))
            {
                MessageBox.Show("End address invalid!");
                return;
            }

            // Make sure they don't scan memory backwards, will crash the game
            if (lAddress > hAddress)
            {
                MessageBox.Show("Start and End addresses backwards!");
                return;
            }

            if (!GlobalFunctions.tryToHex(textBoxComparisonValue.Text, out lValue) && textBoxComparisonValue.Enabled)
            {
                MessageBox.Show("Search value invalid!");
                return;
            }


            //if (enableUpper)
            //{
            //    //if (!GlobalFunctions.tryToHex(upperValue.Text, out hValue))
            //    //{
            //    //    MessageBox.Show("Upper search value invalid!");
            //    //    return;
            //    //}

            //    if (hValue < lValue)
            //    {
            //        UInt32 temp = hValue;
            //        hValue = lValue;
            //        lValue = temp;
            //    }
            //}

            if (useDifference)
            {
                //if (!GlobalFunctions.tryToHex(diffOf.Text, out diffBy))
                //{
                //    MessageBox.Show("Difference value invalid!");
                //    return;
                //}
            }

            if (!ValidMemory.validRange(lAddress, hAddress))
            {
                MessageBox.Show("Memory range invalid!");
                return;
            }

            // Keep the user from doing stuff while we search
            try
            {
                FormStop(false);
                TabLock = searchPage;
                buttonCancelSearch.Enabled = true;
                buttonCancelSearch.BringToFront();
                // Pause Gecko - while changing blocks during block search
                // the game will sometimes move forward a few frames
                bool WasRunning = (gecko.status() == WiiStatus.Running);
                gecko.SafePause();
                //List<SearchComparisonInfo> comparisons = new List<SearchComparisonInfo>();
                //comparisons.Add(new SearchComparisonInfo(cType, lValue));
                bool success = search.SearchRefactored(lAddress, hAddress, searchComparisons, size);


                //bool success = search.Search(lAddress, hAddress, lValue, hValue, enableUpper, type, size, cType, diffBy);
                // If we were running, go back to running
                // If we *weren't* running, *don't* go back to running
                if (WasRunning)
                {
                    gecko.SafeResume();
                }

                FormStop(true);
                buttonCancelSearch.Enabled = false;
                buttonCancelSearch.SendToBack();
                buttonUndoSearch.Enabled = search.CanUndo();
                TabLock = null;

                if (success)
                {
                    Search.Text = "Refine";
                    ResSrch.Enabled = true;
                    search.SaveSearchToIndex(search.DumpNum);
                    SearchHistoryUpdownsInc();
                }
                else
                {
                    ResetSearch();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteException(ex);
                CryError();
            
            */
        }
    }
}