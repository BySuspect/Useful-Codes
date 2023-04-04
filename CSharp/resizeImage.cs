 //Y Height 300
 //X Width  400
 double oldy = 720, oldx = 2100, newy, newx = 1080;

 //yeni boy = (önceki boy * yeni en) / önceki en
 //yeni y = (oldy * yeniX) / oldx
 //yeni y = (300px * 200px) / 400px
 double y = (oldy * newx) / oldx;

//yeni en = (önceki en * yeni boy) / önceki boy
//yeni x = (oldx * y) / oldy
//yeni x = (400px * yeniY) / 300px
double x = (oldx * y) / oldy;
