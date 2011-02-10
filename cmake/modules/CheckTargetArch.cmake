# - This is a support module for checking if the compiled target is 32/64bit
# It define the following macro:
#
# CHECK_TARGET_ARCH ()
#
# if the target is 64bit, the flag TARGET_ARCH_64 will be set

MACRO(CHECK_TARGET_ARCH)
IF(MSVC AND CMAKE_CL_64)
  SET(TARGET_ARCH_64 TRUE)
ELSE()
  IF(CMAKE_SIZEOF_VOID_P EQUAL 8)
    SET(TARGET_ARCH_64 TRUE)
  ENDIF() 
ENDIF()
ENDMACRO(CHECK_TARGET_ARCH)