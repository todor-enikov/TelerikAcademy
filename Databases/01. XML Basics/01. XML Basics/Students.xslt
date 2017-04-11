<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>My students xml</h1>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>Sex</b>
            </td>
            <td>
              <b>Birth Date</b>
            </td>
            <td>
              <b>Phone number</b>
            </td>
            <td>
              <b>E-mail</b>
            </td>
          </tr>
          <xsl:for-each select="/students/student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name">
                </xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="sex">
                </xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="birthDate">
                </xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="phone">
                </xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="email">
                </xsl:value-of>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
