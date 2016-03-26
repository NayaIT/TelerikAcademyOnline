<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <style>
        body {
        text-align: center;
        }
        
        table {
        font-size: 18px;
        }
        
        th, td {
        padding: 5px;
        }
      </style>
      <body>
        <table bgcolor="#CCFFFF" style="font-size:1.1em">
          <tr bgcolor="#33CCFF">
            <th>Student</th>
            <th>Gender</th>
            <th>Birth Date</th>
            <th>Phone</th>
            <th>E-mail</th>
            <th>Course</th>
            <th>Speciality</th>
            <th>Faculty Number</th>
            <th>Exams</th>
          </tr>
          <xsl:for-each select="students/student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name" />
              </td>
              <td>
                <xsl:value-of select="sex" />
              </td>
              <td>
                <xsl:value-of select="birthDate" />
              </td>
              <td>
                <xsl:value-of select="phone" />
              </td>
              <td>
                <xsl:value-of select="email" />
              </td>
              <td>
                <xsl:value-of select="course" />
              </td>
              <td>
                <xsl:value-of select="speciality" />
              </td>
              <td>
                <xsl:value-of select="facultyNumber" />
              </td>
              <td>
                <table cellspacing="1">
                  <tr bgcolor="#33CCFF">
                    <th>Course Name</th>
                    <th>Tutor</th>
                    <th>Score</th>
                  </tr>
                  <xsl:for-each select="exams/exam">
                    <tr>
                      <td>
                        <xsl:value-of select="name" />
                      </td>
                      <td>
                        <xsl:value-of select="tutor" />
                      </td>
                      <td>
                        <xsl:value-of select="score" />
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>