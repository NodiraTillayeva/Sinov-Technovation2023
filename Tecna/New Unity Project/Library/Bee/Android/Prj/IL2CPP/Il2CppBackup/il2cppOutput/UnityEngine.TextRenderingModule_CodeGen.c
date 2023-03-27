#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void UnityEngine.TextMesh::set_text(System.String)
extern void TextMesh_set_text_mDF79D39638ED82797D0B0B3BB9E6B10712F8EA9E (void);
// 0x00000002 System.Void UnityEngine.Font::InvokeTextureRebuilt_Internal(UnityEngine.Font)
extern void Font_InvokeTextureRebuilt_Internal_m874D1025267C908E5FCD437B41929E4DE248B01B (void);
// 0x00000003 System.Void UnityEngine.Font/FontTextureRebuildCallback::.ctor(System.Object,System.IntPtr)
extern void FontTextureRebuildCallback__ctor_m1AF27FC83F3136E493F47015F99CE7A4E6BCA0BC (void);
// 0x00000004 System.Void UnityEngine.Font/FontTextureRebuildCallback::Invoke()
extern void FontTextureRebuildCallback_Invoke_m8B52C3F4823ADBB80062209E6BA2B33202AE958D (void);
static Il2CppMethodPointer s_methodPointers[4] = 
{
	TextMesh_set_text_mDF79D39638ED82797D0B0B3BB9E6B10712F8EA9E,
	Font_InvokeTextureRebuilt_Internal_m874D1025267C908E5FCD437B41929E4DE248B01B,
	FontTextureRebuildCallback__ctor_m1AF27FC83F3136E493F47015F99CE7A4E6BCA0BC,
	FontTextureRebuildCallback_Invoke_m8B52C3F4823ADBB80062209E6BA2B33202AE958D,
};
static const int32_t s_InvokerIndices[4] = 
{
	917,
	2072,
	558,
	1061,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_TextRenderingModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_TextRenderingModule_CodeGenModule = 
{
	"UnityEngine.TextRenderingModule.dll",
	4,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
