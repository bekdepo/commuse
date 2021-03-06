#ifndef __App_H
#define __App_H



class jkBaseDialog;

class jkApp
{
	friend class jkBaseDialog;
public:
	jkApp();
	//void SetInstance(HINSTANCE hIns);
	HINSTANCE GetInstance();

	BOOL SetMainWndInfo(jkBaseDialog* pMainWnd);

	void RunLoop();
protected:
	
private:

};


class jkBaseDialog
{
	friend class jkApp;
	friend BOOL Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam);
public:
	jkBaseDialog(HWND hParant= NULL);
	virtual ~jkBaseDialog();

	operator HWND()const throw();
	void Show(int nResId);
	void UpdateWindow();
	BOOL CenterWindow();
	void MoveWindow(int x,int y,int w,int h,BOOL bRePaint = FALSE);
	

	virtual void OnInitDialog();
	virtual void OnOk();
	virtual void OnCancel();
	virtual LRESULT OnCommand(WPARAM w,LPARAM l);
	virtual LRESULT OnDropFiles(HDROP hDrop);

	virtual LRESULT MessageHandle(HWND hwnd,UINT uMsg,WPARAM wParam,LPARAM lParam);

	HWND GetCtrl(int nResId);

protected:
	HWND hParant;
	HWND mHwnd;
};

class jkBaseWindow
{
	friend class jkApp;
	friend LRESULT CALLBACK CLS_WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);
public:
	operator HWND()const throw();
	void Create(HWND hParant,LPCSTR szTitle = NULL,DWORD dwStyle = 0,LPCSTR szWndClass = NULL);
	void Show(int nCmd);
	void UpdateWindow();
	BOOL CenterWindow();
	void MoveWindow(int x,int y,int w,int h,BOOL bRePaint = FALSE);

	virtual void OnCreate(LPCREATESTRUCT pStruct);
	virtual void OnPaint(HDC hdc);
	virtual void OnSize(UINT nSizeCmd,int width,int height);
	virtual HBRUSH OnCtrlColor();
	virtual BOOL OnEraseBackground(HDC hdc);
	virtual void OnLButtonDown(UINT nFlags,int x, int y);
	virtual void OnLButtonUp(UINT nFlags,int x, int y);
	virtual void OnLButtonDBClick(UINT nFlags,int x, int y);
	virtual LRESULT MessageHandle(HWND hWnd,UINT uMsg,WPARAM wParam,LPARAM lParam);
protected:
	HWND mHwnd;
private:
	
};


//-------------------------------------------------------------------------------

extern jkApp theJKApp;
#endif //__App_H