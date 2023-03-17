using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorSwizzle
{
    public static Vector3 _xxx(this Vector2 v) { return new Vector3(v.x, v.x, v.x); }
    public static Vector3 _xxy(this Vector2 v) { return new Vector3(v.x, v.x, v.y); }
    public static Vector3 _xx0(this Vector2 v) { return new Vector3(v.x, v.x, 0); }
    public static Vector3 _xx1(this Vector2 v) { return new Vector3(v.x, v.x, 1); }
    public static Vector3 _xyx(this Vector2 v) { return new Vector3(v.x, v.y, v.x); }
    public static Vector3 _xyy(this Vector2 v) { return new Vector3(v.x, v.y, v.y); }
    public static Vector3 _xy0(this Vector2 v) { return new Vector3(v.x, v.y, 0); }
    public static Vector3 _xy1(this Vector2 v) { return new Vector3(v.x, v.y, 1); }
    public static Vector3 _x0x(this Vector2 v) { return new Vector3(v.x, 0, v.x); }
    public static Vector3 _x0y(this Vector2 v) { return new Vector3(v.x, 0, v.y); }
    public static Vector3 _x00(this Vector2 v) { return new Vector3(v.x, 0, 0); }
    public static Vector3 _x01(this Vector2 v) { return new Vector3(v.x, 0, 1); }
    public static Vector3 _x1x(this Vector2 v) { return new Vector3(v.x, 1, v.x); }
    public static Vector3 _x1y(this Vector2 v) { return new Vector3(v.x, 1, v.y); }
    public static Vector3 _x10(this Vector2 v) { return new Vector3(v.x, 1, 0); }
    public static Vector3 _x11(this Vector2 v) { return new Vector3(v.x, 1, 1); }
    public static Vector3 _yxx(this Vector2 v) { return new Vector3(v.y, v.x, v.x); }
    public static Vector3 _yxy(this Vector2 v) { return new Vector3(v.y, v.x, v.y); }
    public static Vector3 _yx0(this Vector2 v) { return new Vector3(v.y, v.x, 0); }
    public static Vector3 _yx1(this Vector2 v) { return new Vector3(v.y, v.x, 1); }
    public static Vector3 _yyx(this Vector2 v) { return new Vector3(v.y, v.y, v.x); }
    public static Vector3 _yyy(this Vector2 v) { return new Vector3(v.y, v.y, v.y); }
    public static Vector3 _yy0(this Vector2 v) { return new Vector3(v.y, v.y, 0); }
    public static Vector3 _yy1(this Vector2 v) { return new Vector3(v.y, v.y, 1); }
    public static Vector3 _y0x(this Vector2 v) { return new Vector3(v.y, 0, v.x); }
    public static Vector3 _y0y(this Vector2 v) { return new Vector3(v.y, 0, v.y); }
    public static Vector3 _y00(this Vector2 v) { return new Vector3(v.y, 0, 0); }
    public static Vector3 _y01(this Vector2 v) { return new Vector3(v.y, 0, 1); }
    public static Vector3 _y1x(this Vector2 v) { return new Vector3(v.y, 1, v.x); }
    public static Vector3 _y1y(this Vector2 v) { return new Vector3(v.y, 1, v.y); }
    public static Vector3 _y10(this Vector2 v) { return new Vector3(v.y, 1, 0); }
    public static Vector3 _y11(this Vector2 v) { return new Vector3(v.y, 1, 1); }
    public static Vector3 _0xx(this Vector2 v) { return new Vector3(0, v.x, v.x); }
    public static Vector3 _0xy(this Vector2 v) { return new Vector3(0, v.x, v.y); }
    public static Vector3 _0x0(this Vector2 v) { return new Vector3(0, v.x, 0); }
    public static Vector3 _0x1(this Vector2 v) { return new Vector3(0, v.x, 1); }
    public static Vector3 _0yx(this Vector2 v) { return new Vector3(0, v.y, v.x); }
    public static Vector3 _0yy(this Vector2 v) { return new Vector3(0, v.y, v.y); }
    public static Vector3 _0y0(this Vector2 v) { return new Vector3(0, v.y, 0); }
    public static Vector3 _0y1(this Vector2 v) { return new Vector3(0, v.y, 1); }
    public static Vector3 _00x(this Vector2 v) { return new Vector3(0, 0, v.x); }
    public static Vector3 _00y(this Vector2 v) { return new Vector3(0, 0, v.y); }
    public static Vector3 _000(this Vector2 v) { return new Vector3(0, 0, 0); }
    public static Vector3 _001(this Vector2 v) { return new Vector3(0, 0, 1); }
    public static Vector3 _01x(this Vector2 v) { return new Vector3(0, 1, v.x); }
    public static Vector3 _01y(this Vector2 v) { return new Vector3(0, 1, v.y); }
    public static Vector3 _010(this Vector2 v) { return new Vector3(0, 1, 0); }
    public static Vector3 _011(this Vector2 v) { return new Vector3(0, 1, 1); }
    public static Vector3 _1xx(this Vector2 v) { return new Vector3(1, v.x, v.x); }
    public static Vector3 _1xy(this Vector2 v) { return new Vector3(1, v.x, v.y); }
    public static Vector3 _1x0(this Vector2 v) { return new Vector3(1, v.x, 0); }
    public static Vector3 _1x1(this Vector2 v) { return new Vector3(1, v.x, 1); }
    public static Vector3 _1yx(this Vector2 v) { return new Vector3(1, v.y, v.x); }
    public static Vector3 _1yy(this Vector2 v) { return new Vector3(1, v.y, v.y); }
    public static Vector3 _1y0(this Vector2 v) { return new Vector3(1, v.y, 0); }
    public static Vector3 _1y1(this Vector2 v) { return new Vector3(1, v.y, 1); }
    public static Vector3 _10x(this Vector2 v) { return new Vector3(1, 0, v.x); }
    public static Vector3 _10y(this Vector2 v) { return new Vector3(1, 0, v.y); }
    public static Vector3 _100(this Vector2 v) { return new Vector3(1, 0, 0); }
    public static Vector3 _101(this Vector2 v) { return new Vector3(1, 0, 1); }
    public static Vector3 _11x(this Vector2 v) { return new Vector3(1, 1, v.x); }
    public static Vector3 _11y(this Vector2 v) { return new Vector3(1, 1, v.y); }
    public static Vector3 _110(this Vector2 v) { return new Vector3(1, 1, 0); }
    public static Vector3 _111(this Vector2 v) { return new Vector3(1, 1, 1); }

    public static Vector2 _xx(this Vector3 v) => new Vector2(v.x, v.x);
    public static Vector2 _xy(this Vector3 v) => new Vector2(v.x, v.y);
    public static Vector2 _xz(this Vector3 v) => new Vector2(v.x, v.z);
    public static Vector2 _x0(this Vector3 v) => new Vector2(v.x, 0);
    public static Vector2 _x1(this Vector3 v) => new Vector2(v.x, 1);

    public static Vector2 _yx(this Vector3 v) => new Vector2(v.y, v.x);
    public static Vector2 _yy(this Vector3 v) => new Vector2(v.y, v.y);
    public static Vector2 _yz(this Vector3 v) => new Vector2(v.y, v.z);
    public static Vector2 _y0(this Vector3 v) => new Vector2(v.y, 0);
    public static Vector2 _y1(this Vector3 v) => new Vector2(v.y, 1);

    public static Vector2 _zx(this Vector3 v) => new Vector2(v.z, v.x);
    public static Vector2 _zy(this Vector3 v) => new Vector2(v.z, v.y);
    public static Vector2 _zz(this Vector3 v) => new Vector2(v.z, v.z);
    public static Vector2 _z0(this Vector3 v) => new Vector2(v.z, 0);
    public static Vector2 _z1(this Vector3 v) => new Vector2(v.z, 1);

    public static Vector2 _0x(this Vector3 v) => new Vector2(0, v.x);
    public static Vector2 _0y(this Vector3 v) => new Vector2(0, v.y);
    public static Vector2 _0z(this Vector3 v) => new Vector2(0, v.z);
    public static Vector2 _00(this Vector3 v) => new Vector2(0, 0);
    public static Vector2 _01(this Vector3 v) => new Vector2(0, 1);

    public static Vector2 _1x(this Vector3 v) => new Vector2(1, v.x);
    public static Vector2 _1y(this Vector3 v) => new Vector2(1, v.y);
    public static Vector2 _1z(this Vector3 v) => new Vector2(1, v.z);
    public static Vector2 _10(this Vector3 v) => new Vector2(1, 0);
    public static Vector2 _11(this Vector3 v) => new Vector2(1, 1);

    public static Vector2 _xx(this Vector2 v) => new Vector2(v.x, v.x);
    public static Vector2 _xy(this Vector2 v) => new Vector2(v.x, v.y);
    public static Vector2 _x0(this Vector2 v) => new Vector2(v.x, 0);
    public static Vector2 _x1(this Vector2 v) => new Vector2(v.x, 1);

    public static Vector2 _yx(this Vector2 v) => new Vector2(v.y, v.x);
    public static Vector2 _yy(this Vector2 v) => new Vector2(v.y, v.y);    
    public static Vector2 _y0(this Vector2 v) => new Vector2(v.y, 0);
    public static Vector2 _y1(this Vector2 v) => new Vector2(v.y, 1);
    
    public static Vector2 _0x(this Vector2 v) => new Vector2(0, v.x);
    public static Vector2 _0y(this Vector2 v) => new Vector2(0, v.y);
    public static Vector2 _00(this Vector2 v) => new Vector2(0, 0);
    public static Vector2 _01(this Vector2 v) => new Vector2(0, 1);

    public static Vector2 _1x(this Vector2 v) => new Vector2(1, v.x);
    public static Vector2 _1y(this Vector2 v) => new Vector2(1, v.y);
    public static Vector2 _10(this Vector2 v) => new Vector2(1, 0);
    public static Vector2 _11(this Vector2 v) => new Vector2(1, 1);

    public static Vector3 _xxx(this Vector3 v) { return new Vector3(v.x, v.x, v.x); }
    public static Vector3 _xxy(this Vector3 v) { return new Vector3(v.x, v.x, v.y); }
    public static Vector3 _xxz(this Vector3 v) { return new Vector3(v.x, v.x, v.z); }
    public static Vector3 _xx0(this Vector3 v) { return new Vector3(v.x, v.x, 0); }
    public static Vector3 _xx1(this Vector3 v) { return new Vector3(v.x, v.x, 1); }
    public static Vector3 _xyx(this Vector3 v) { return new Vector3(v.x, v.y, v.x); }
    public static Vector3 _xyy(this Vector3 v) { return new Vector3(v.x, v.y, v.y); }
    public static Vector3 _xyz(this Vector3 v) { return new Vector3(v.x, v.y, v.z); }
    public static Vector3 _xy0(this Vector3 v) { return new Vector3(v.x, v.y, 0); }
    public static Vector3 _xy1(this Vector3 v) { return new Vector3(v.x, v.y, 1); }
    public static Vector3 _xzx(this Vector3 v) { return new Vector3(v.x, v.z, v.x); }
    public static Vector3 _xzy(this Vector3 v) { return new Vector3(v.x, v.z, v.y); }
    public static Vector3 _xzz(this Vector3 v) { return new Vector3(v.x, v.z, v.z); }
    public static Vector3 _xz0(this Vector3 v) { return new Vector3(v.x, v.z, 0); }
    public static Vector3 _xz1(this Vector3 v) { return new Vector3(v.x, v.z, 1); }
    public static Vector3 _x0x(this Vector3 v) { return new Vector3(v.x, 0, v.x); }
    public static Vector3 _x0y(this Vector3 v) { return new Vector3(v.x, 0, v.y); }
    public static Vector3 _x0z(this Vector3 v) { return new Vector3(v.x, 0, v.z); }
    public static Vector3 _x00(this Vector3 v) { return new Vector3(v.x, 0, 0); }
    public static Vector3 _x01(this Vector3 v) { return new Vector3(v.x, 0, 1); }
    public static Vector3 _x1x(this Vector3 v) { return new Vector3(v.x, 1, v.x); }
    public static Vector3 _x1y(this Vector3 v) { return new Vector3(v.x, 1, v.y); }
    public static Vector3 _x1z(this Vector3 v) { return new Vector3(v.x, 1, v.z); }
    public static Vector3 _x10(this Vector3 v) { return new Vector3(v.x, 1, 0); }
    public static Vector3 _x11(this Vector3 v) { return new Vector3(v.x, 1, 1); }
    public static Vector3 _yxx(this Vector3 v) { return new Vector3(v.y, v.x, v.x); }
    public static Vector3 _yxy(this Vector3 v) { return new Vector3(v.y, v.x, v.y); }
    public static Vector3 _yxz(this Vector3 v) { return new Vector3(v.y, v.x, v.z); }
    public static Vector3 _yx0(this Vector3 v) { return new Vector3(v.y, v.x, 0); }
    public static Vector3 _yx1(this Vector3 v) { return new Vector3(v.y, v.x, 1); }
    public static Vector3 _yyx(this Vector3 v) { return new Vector3(v.y, v.y, v.x); }
    public static Vector3 _yyy(this Vector3 v) { return new Vector3(v.y, v.y, v.y); }
    public static Vector3 _yyz(this Vector3 v) { return new Vector3(v.y, v.y, v.z); }
    public static Vector3 _yy0(this Vector3 v) { return new Vector3(v.y, v.y, 0); }
    public static Vector3 _yy1(this Vector3 v) { return new Vector3(v.y, v.y, 1); }
    public static Vector3 _yzx(this Vector3 v) { return new Vector3(v.y, v.z, v.x); }
    public static Vector3 _yzy(this Vector3 v) { return new Vector3(v.y, v.z, v.y); }
    public static Vector3 _yzz(this Vector3 v) { return new Vector3(v.y, v.z, v.z); }
    public static Vector3 _yz0(this Vector3 v) { return new Vector3(v.y, v.z, 0); }
    public static Vector3 _yz1(this Vector3 v) { return new Vector3(v.y, v.z, 1); }
    public static Vector3 _y0x(this Vector3 v) { return new Vector3(v.y, 0, v.x); }
    public static Vector3 _y0y(this Vector3 v) { return new Vector3(v.y, 0, v.y); }
    public static Vector3 _y0z(this Vector3 v) { return new Vector3(v.y, 0, v.z); }
    public static Vector3 _y00(this Vector3 v) { return new Vector3(v.y, 0, 0); }
    public static Vector3 _y01(this Vector3 v) { return new Vector3(v.y, 0, 1); }
    public static Vector3 _y1x(this Vector3 v) { return new Vector3(v.y, 1, v.x); }
    public static Vector3 _y1y(this Vector3 v) { return new Vector3(v.y, 1, v.y); }
    public static Vector3 _y1z(this Vector3 v) { return new Vector3(v.y, 1, v.z); }
    public static Vector3 _y10(this Vector3 v) { return new Vector3(v.y, 1, 0); }
    public static Vector3 _y11(this Vector3 v) { return new Vector3(v.y, 1, 1); }
    public static Vector3 _zxx(this Vector3 v) { return new Vector3(v.z, v.x, v.x); }
    public static Vector3 _zxy(this Vector3 v) { return new Vector3(v.z, v.x, v.y); }
    public static Vector3 _zxz(this Vector3 v) { return new Vector3(v.z, v.x, v.z); }
    public static Vector3 _zx0(this Vector3 v) { return new Vector3(v.z, v.x, 0); }
    public static Vector3 _zx1(this Vector3 v) { return new Vector3(v.z, v.x, 1); }
    public static Vector3 _zyx(this Vector3 v) { return new Vector3(v.z, v.y, v.x); }
    public static Vector3 _zyy(this Vector3 v) { return new Vector3(v.z, v.y, v.y); }
    public static Vector3 _zyz(this Vector3 v) { return new Vector3(v.z, v.y, v.z); }
    public static Vector3 _zy0(this Vector3 v) { return new Vector3(v.z, v.y, 0); }
    public static Vector3 _zy1(this Vector3 v) { return new Vector3(v.z, v.y, 1); }
    public static Vector3 _zzx(this Vector3 v) { return new Vector3(v.z, v.z, v.x); }
    public static Vector3 _zzy(this Vector3 v) { return new Vector3(v.z, v.z, v.y); }
    public static Vector3 _zzz(this Vector3 v) { return new Vector3(v.z, v.z, v.z); }
    public static Vector3 _zz0(this Vector3 v) { return new Vector3(v.z, v.z, 0); }
    public static Vector3 _zz1(this Vector3 v) { return new Vector3(v.z, v.z, 1); }
    public static Vector3 _z0x(this Vector3 v) { return new Vector3(v.z, 0, v.x); }
    public static Vector3 _z0y(this Vector3 v) { return new Vector3(v.z, 0, v.y); }
    public static Vector3 _z0z(this Vector3 v) { return new Vector3(v.z, 0, v.z); }
    public static Vector3 _z00(this Vector3 v) { return new Vector3(v.z, 0, 0); }
    public static Vector3 _z01(this Vector3 v) { return new Vector3(v.z, 0, 1); }
    public static Vector3 _z1x(this Vector3 v) { return new Vector3(v.z, 1, v.x); }
    public static Vector3 _z1y(this Vector3 v) { return new Vector3(v.z, 1, v.y); }
    public static Vector3 _z1z(this Vector3 v) { return new Vector3(v.z, 1, v.z); }
    public static Vector3 _z10(this Vector3 v) { return new Vector3(v.z, 1, 0); }
    public static Vector3 _z11(this Vector3 v) { return new Vector3(v.z, 1, 1); }
    public static Vector3 _0xx(this Vector3 v) { return new Vector3(0, v.x, v.x); }
    public static Vector3 _0xy(this Vector3 v) { return new Vector3(0, v.x, v.y); }
    public static Vector3 _0xz(this Vector3 v) { return new Vector3(0, v.x, v.z); }
    public static Vector3 _0x0(this Vector3 v) { return new Vector3(0, v.x, 0); }
    public static Vector3 _0x1(this Vector3 v) { return new Vector3(0, v.x, 1); }
    public static Vector3 _0yx(this Vector3 v) { return new Vector3(0, v.y, v.x); }
    public static Vector3 _0yy(this Vector3 v) { return new Vector3(0, v.y, v.y); }
    public static Vector3 _0yz(this Vector3 v) { return new Vector3(0, v.y, v.z); }
    public static Vector3 _0y0(this Vector3 v) { return new Vector3(0, v.y, 0); }
    public static Vector3 _0y1(this Vector3 v) { return new Vector3(0, v.y, 1); }
    public static Vector3 _0zx(this Vector3 v) { return new Vector3(0, v.z, v.x); }
    public static Vector3 _0zy(this Vector3 v) { return new Vector3(0, v.z, v.y); }
    public static Vector3 _0zz(this Vector3 v) { return new Vector3(0, v.z, v.z); }
    public static Vector3 _0z0(this Vector3 v) { return new Vector3(0, v.z, 0); }
    public static Vector3 _0z1(this Vector3 v) { return new Vector3(0, v.z, 1); }
    public static Vector3 _00x(this Vector3 v) { return new Vector3(0, 0, v.x); }
    public static Vector3 _00y(this Vector3 v) { return new Vector3(0, 0, v.y); }
    public static Vector3 _00z(this Vector3 v) { return new Vector3(0, 0, v.z); }
    public static Vector3 _000(this Vector3 v) { return new Vector3(0, 0, 0); }
    public static Vector3 _001(this Vector3 v) { return new Vector3(0, 0, 1); }
    public static Vector3 _01x(this Vector3 v) { return new Vector3(0, 1, v.x); }
    public static Vector3 _01y(this Vector3 v) { return new Vector3(0, 1, v.y); }
    public static Vector3 _01z(this Vector3 v) { return new Vector3(0, 1, v.z); }
    public static Vector3 _010(this Vector3 v) { return new Vector3(0, 1, 0); }
    public static Vector3 _011(this Vector3 v) { return new Vector3(0, 1, 1); }
    public static Vector3 _1xx(this Vector3 v) { return new Vector3(1, v.x, v.x); }
    public static Vector3 _1xy(this Vector3 v) { return new Vector3(1, v.x, v.y); }
    public static Vector3 _1xz(this Vector3 v) { return new Vector3(1, v.x, v.z); }
    public static Vector3 _1x0(this Vector3 v) { return new Vector3(1, v.x, 0); }
    public static Vector3 _1x1(this Vector3 v) { return new Vector3(1, v.x, 1); }
    public static Vector3 _1yx(this Vector3 v) { return new Vector3(1, v.y, v.x); }
    public static Vector3 _1yy(this Vector3 v) { return new Vector3(1, v.y, v.y); }
    public static Vector3 _1yz(this Vector3 v) { return new Vector3(1, v.y, v.z); }
    public static Vector3 _1y0(this Vector3 v) { return new Vector3(1, v.y, 0); }
    public static Vector3 _1y1(this Vector3 v) { return new Vector3(1, v.y, 1); }
    public static Vector3 _1zx(this Vector3 v) { return new Vector3(1, v.z, v.x); }
    public static Vector3 _1zy(this Vector3 v) { return new Vector3(1, v.z, v.y); }
    public static Vector3 _1zz(this Vector3 v) { return new Vector3(1, v.z, v.z); }
    public static Vector3 _1z0(this Vector3 v) { return new Vector3(1, v.z, 0); }
    public static Vector3 _1z1(this Vector3 v) { return new Vector3(1, v.z, 1); }
    public static Vector3 _10x(this Vector3 v) { return new Vector3(1, 0, v.x); }
    public static Vector3 _10y(this Vector3 v) { return new Vector3(1, 0, v.y); }
    public static Vector3 _10z(this Vector3 v) { return new Vector3(1, 0, v.z); }
    public static Vector3 _100(this Vector3 v) { return new Vector3(1, 0, 0); }
    public static Vector3 _101(this Vector3 v) { return new Vector3(1, 0, 1); }
    public static Vector3 _11x(this Vector3 v) { return new Vector3(1, 1, v.x); }
    public static Vector3 _11y(this Vector3 v) { return new Vector3(1, 1, v.y); }
    public static Vector3 _11z(this Vector3 v) { return new Vector3(1, 1, v.z); }
    public static Vector3 _110(this Vector3 v) { return new Vector3(1, 1, 0); }
    public static Vector3 _111(this Vector3 v) { return new Vector3(1, 1, 1); }
}