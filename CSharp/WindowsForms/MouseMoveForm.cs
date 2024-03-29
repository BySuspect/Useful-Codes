 #region Mouse move codes
 private Point _mouseLoc;
 private void FormMouseDown(object sender, MouseEventArgs e)
 {
     _mouseLoc = e.Location;
 }
 private void FormMouseMove(object sender, MouseEventArgs e)
 {
     if (e.Button == MouseButtons.Left)
     {
         int dx = e.Location.X - _mouseLoc.X;
         int dy = e.Location.Y - _mouseLoc.Y;
         this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
     }
 }
 #endregion
