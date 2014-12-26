/////////////////////////////////////////////////////////////////////////////
// WebGrab.h : header file
//
// CWebGrab - CHttpFile wrapper class
//
// Written by Chris Maunder <cmaunder@mail.com>
// Copyright (c) 1998-2002. All Rights Reserved.
//
// This code may be used in compiled form in any way you desire. This
// file may be redistributed unmodified by any means PROVIDING it is 
// not sold for profit without the authors written consent, and 
// providing that this notice and the authors name and all copyright 
// notices remains intact. 
//
// An email letting me know how you are using it would be nice as well. 
//
// This file is provided "as is" with no expressed or implied warranty.
// The author accepts no liability for any damage/loss of business that
// this product may cause.
//
// History: 19 Nov 1999 - Release
//          26 Jan 2002 - Update by Bryce to include Proxy support and
//                        property accessors (transfer rate, error msg
//                        etc)
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_WEBGRAB_H__D31F39A4_1C63_11D3_AA11_AC48B5000000__INCLUDED_)
#define AFX_WEBGRAB_H__D31F39A4_1C63_11D3_AA11_AC48B5000000__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// WebGrab.h : header file
//

#include <afxinet.h>
#include <vector>
//#include "Define.h"

/////////////////////////////////////////////////////////////////////////////
// CWebGrabSession 

class CWebGrabSession : public CInternetSession
{
// Construction
public:
	CWebGrabSession(LPCTSTR szAgentName);
	CWebGrabSession(LPCTSTR szAgentName, CWnd* pStatusWnd);
	virtual ~CWebGrabSession();
    void CommonConstruct();

// Operations
public:
    void SetStatus(LPCTSTR fmt, ...);
    void SetStatusWnd(CWnd* pWnd)     { m_pStatusWnd = pWnd; }

// Overrides
public:
	CString GetErrorMessage();
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CWebGrabSession)
	//}}AFX_VIRTUAL
    virtual void OnStatusCallback(DWORD dwContext, DWORD dwInternetStatus, 
                                  LPVOID lpvStatusInformation, 
                                  DWORD dwStatusInformationLength);

	// Generated message map functions
	//{{AFX_MSG(CWebGrabSession)
	//}}AFX_MSG

// Attributes
protected:
    CWnd* m_pStatusWnd;
	CString errorMessage;

};


/////////////////////////////////////////////////////////////////////////////
// CWebGrab 

class CWebGrab : public CObject
{
public:
	enum
	{
		eDownloadContinue,
		eDownloadOver,
		eDownloadError,
	};
public:
	CWebGrab();
	virtual ~CWebGrab();

// Operations
public:
    BOOL Initialise(LPCTSTR szAgentName = NULL, CWnd* pWnd = NULL);
 

    BOOL GetFile(LPCTSTR szURL, CString& strBuffer, 
                 LPCTSTR szAgentName = NULL, CWnd* pWnd = NULL);
	BOOL GetFile(LPCTSTR szURL, std::vector<char>& buffer, 
		DWORD& dwCurDowned,DWORD& dwTotal,
		LPCTSTR szAgentName = NULL , CWnd* pWnd = NULL );

	 void Close();
	// Overrides
public:
	CString GetRawHeaders();
	CString GetSocksHttp(LPCSTR url);
	CString GetErrorMessage();

	DWORD	GetPageStatusCode();
	SHORT   GetErrorCode();
	double  GetRate();

	void    SetUseProxy(bool use);
	void    SetProxy(LPCSTR proxy, WORD port,bool use=true);
	void    SetProxyPort(UINT port);
	void    SetProxyServer(LPCSTR server);
	void    SetTimeOut(DWORD timeOut);

	BOOL	BeginDownload(	LPCTSTR szURL, 
							LPCTSTR szAgentName /*=NULL*/, 
							CWnd* pWnd /*=NULL*/);
	DWORD	DownloadSome();
	void	EndDownload();
	CString* GetBuffer(){ return &m_strBuffer; }
	DWORD	GetDownSize() const;
	void	SetDownSize(DWORD dwSize = 0);

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CWebGrab)
	//}}AFX_VIRTUAL

	// Generated message map functions
	//{{AFX_MSG(CWebGrab))
	//}}AFX_MSG

protected:
    CWebGrabSession* m_pSession;
	DWORD   m_timeOut;

private:
	double  m_transferRate;
	bool    m_useProxy;
	UINT    m_Port;
	DWORD	m_infoStatusCode;

	CString m_ErrorMessage;
	CString m_Proxy;
	CString	m_rawHeaders;

	// moting added 2005.03.27
	CString	m_strBuffer;
	CHttpFile* m_pFile;
	LPSTR	m_pBuf;
	DWORD	m_dwCount;
	DWORD   m_dwDownSize;
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_WEBGRAB_H__D31F39A4_1C63_11D3_AA11_AC48B5000000__INCLUDED_)
