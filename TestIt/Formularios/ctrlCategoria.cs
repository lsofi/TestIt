using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Logica;
using TestIt.Soporte;

namespace TestIt.Formularios
{
    public partial class ctrlCategoria : UserControl
    {
        CategoriaService sCategoria = new CategoriaService();
        private List<Categoria> lCategoria;
        private bool nuevo = false;

        public ctrlCategoria()
        {
            InitializeComponent();
        }

        private void ctrlCategoria_Load(object sender, EventArgs e)
        {
            lCategoria = sCategoria.buscarTodos();
            cargarGrilla();

        }

        private void cargarGrilla()
        {
            grdCategoría.Rows.Clear();

            if (lCategoria != null)
                foreach (Categoria categoria in lCategoria)
                {
                    grdCategoría.Rows.Add(categoria.Id, categoria.Nombre);
                }
            grdCategoría.ClearSelection();
        }

        private void toggleEdit(bool edit)
        {
            btnAceptar.Enabled = edit;
            btnCancelar.Enabled = edit;
            btnAgregar.Enabled = !edit;

            txtNombreDet.Enabled = edit;
            txtEdadMinDet.Enabled = edit;
            txtEdadMaxDet.Enabled = edit;

            grdCategoría.Enabled = !edit;

            if (grdCategoría.SelectedRows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = !edit;
                btnEliminar.Enabled = !edit;
            }
        }
        private void grdCategoría_SelectionChanged_1(object sender, EventArgs e)
        {
            if (grdCategoría.SelectedRows.Count == 0)
                limpiarCampos();
            else
                cargarCampos();
        }

        private void cargarCampos()
        {
            Categoria categoria = catActual();

            txtNombreDet.Text = categoria.Nombre;
            txtEdadMinDet.Text = categoria.EdadMin.ToString();
            txtEdadMaxDet.Text = categoria.EdadMax.ToString();

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarCampos()
        {

            txtNombreDet.Text = " ";
            txtEdadMinDet.Text = " ";
            txtEdadMaxDet.Text = " ";
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private Categoria catActual()
        {
            foreach (Categoria categoria in lCategoria)
                if (categoria.Id == (int)grdCategoría.SelectedRows[0].Cells[0].Value)
                    return categoria;
            return null;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            grdCategoría.ClearSelection();
            toggleEdit(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleEdit(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria cat = catActual();
            DialogResult answer = MessageBox.Show("¿Desea eliminar la categría " + cat.Nombre + "?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (answer == DialogResult.Yes)
            {
                if (sCategoria.eliminar(cat))
                {
                    MessageBox.Show("Categoría eliminada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lCategoria = sCategoria.buscarTodos();
                    cargarGrilla();
                }

                else
                    MessageBox.Show("Error al eliminar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                Categoria categoria = nuevo ? new Categoria() :catActual();
                categoria.Nombre = txtNombreDet.Text;
                categoria.EdadMin = int.Parse(txtEdadMinDet.Text);
                categoria.EdadMax = int.Parse(txtEdadMaxDet.Text);

                if (nuevo)
                {
                    categoria.Borrado = 0;
                    if (sCategoria.grabar(categoria))
                    {
                        
                        MessageBox.Show("Categoría grabada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lCategoria = sCategoria.buscarTodos();
                        cargarGrilla();
                    }
                    else
                        MessageBox.Show("Error al grabar la categoriía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo = false;
                }
                else
                {
                    if (sCategoria.actualizar(categoria))
                    {
                        
                        MessageBox.Show("Categoría actualizada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lCategoria = sCategoria.buscarTodos();
                        cargarGrilla();
                    }
                    else
                        MessageBox.Show("Error al actualizar la categoriía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toggleEdit(false);
            }
            else
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
  
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            toggleEdit(false);
            grdCategoría.ClearSelection();
        }

        private bool validarCampos()

        {
            if (txtNombreDet.Text == "") return false;
            if (txtEdadMinDet.Text == "") return false;
            if (txtEdadMaxDet.Text == "") return false;
            return true;
        }

    }
}
 