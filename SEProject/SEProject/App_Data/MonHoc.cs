using System;

public class MonHoc
{
    //Variables
    private String tenMonhoc;
    private String maMonHoc;
    private int soTinChi, gioLyThuyet, gioThucHanh, gioTuHoc;
    private String khoiKienThuc;
    private String monTienQuyet;
    //end var

    //Constructor
	public MonHoc()
	{
        tenMonhoc = "";
        maMonHoc = "";
        soTinChi = gioLyThuyet = gioTuHoc = gioThucHanh = 0;
        khoiKienThuc = "";
        monTienQuyet = "";
	}

    public MonHoc(String tenMonhoc, String maMonHoc, int soTinChi, int gioLyThuyet, int gioThucHanh,
                  int gioTuHoc, String khoiKienThuc, String monTienQuyet)
    {
        this.tenMonhoc = tenMonhoc;
        this.maMonHoc = maMonHoc;
        setTinChi(soTinChi, gioLyThuyet, gioThucHanh, gioTuHoc);
        this.khoiKienThuc = khoiKienThuc;
        this.monTienQuyet = monTienQuyet;
    }//end Constructor
    
    //Method Set, Get
    public void setTenMonHoc(String tenMonhoc)
    {
        this.tenMonhoc = tenMonhoc;
    }
    public String getTenMonHoc()
    {
        return tenMonhoc;
    }
    public void setMaMonHoc(String maMonHoc)
    {
        this.maMonHoc = maMonHoc;
    }
    public String getMaMonHoc()
    {
        return maMonHoc;
    }
    public bool checkTinChi(int soTinChi, int gioLyThuyet, int gioThucHanh, int gioTuHoc)
    {
        if (soTinChi*15 == gioLyThuyet + gioThucHanh + gioTuHoc)
        {
            return true;
        }
        else
            return false;
    }
    public void setTinChi(int soTinChi, int gioLyThuyet, int gioThucHanh, int gioTuHoc)
    {
        if (checkTinChi(soTinChi,gioLyThuyet,gioThucHanh,gioTuHoc))
        {
            this.soTinChi = soTinChi;
            this.gioLyThuyet = gioLyThuyet;
            this.gioThucHanh = gioThucHanh;
            this.gioTuHoc = gioTuHoc;
        }
    }
    public int getSoTinChi()
    {
        return soTinChi;
    }
    public int getLyThuyet()
    {
        return gioLyThuyet;
    }
    public int getThucHanh()
    {
        return gioThucHanh;
    }
    public int getTuHoc()
    {
        return gioTuHoc;
    }
    public void setKhoiKienThuc(String khoiKienThuc)
    {
        this.khoiKienThuc = khoiKienThuc;
    }
    public String getKhoiKienThuc()
    {
        return khoiKienThuc;
    }
    public void setMonTienQuyet(String monTienQuyet)
    {
        this.monTienQuyet = monTienQuyet;
    }
    public String getMonTienQuyet()
    {
        return monTienQuyet;
    }
    //end method
}
