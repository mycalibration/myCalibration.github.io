# coding: utf-8

"""
    myCalibration OpenAPI 3 Specification

    myCalibration API  # noqa: E501

    OpenAPI spec version: 1.22.178.1
    Contact: engineering@keller-druck.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class KellerSensorData(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'version': 'str',
        'header': 'Header',
        'compensation_methods': 'CompensationMethods',
        'measurements': 'list[Measurement]'
    }

    attribute_map = {
        'version': 'Version',
        'header': 'Header',
        'compensation_methods': 'CompensationMethods',
        'measurements': 'Measurements'
    }

    def __init__(self, version=None, header=None, compensation_methods=None, measurements=None):  # noqa: E501
        """KellerSensorData - a model defined in Swagger"""  # noqa: E501
        self._version = None
        self._header = None
        self._compensation_methods = None
        self._measurements = None
        self.discriminator = None
        if version is not None:
            self.version = version
        if header is not None:
            self.header = header
        if compensation_methods is not None:
            self.compensation_methods = compensation_methods
        if measurements is not None:
            self.measurements = measurements

    @property
    def version(self):
        """Gets the version of this KellerSensorData.  # noqa: E501

        Version of the corresponding JSON Schema  # noqa: E501

        :return: The version of this KellerSensorData.  # noqa: E501
        :rtype: str
        """
        return self._version

    @version.setter
    def version(self, version):
        """Sets the version of this KellerSensorData.

        Version of the corresponding JSON Schema  # noqa: E501

        :param version: The version of this KellerSensorData.  # noqa: E501
        :type: str
        """

        self._version = version

    @property
    def header(self):
        """Gets the header of this KellerSensorData.  # noqa: E501


        :return: The header of this KellerSensorData.  # noqa: E501
        :rtype: Header
        """
        return self._header

    @header.setter
    def header(self, header):
        """Sets the header of this KellerSensorData.


        :param header: The header of this KellerSensorData.  # noqa: E501
        :type: Header
        """

        self._header = header

    @property
    def compensation_methods(self):
        """Gets the compensation_methods of this KellerSensorData.  # noqa: E501


        :return: The compensation_methods of this KellerSensorData.  # noqa: E501
        :rtype: CompensationMethods
        """
        return self._compensation_methods

    @compensation_methods.setter
    def compensation_methods(self, compensation_methods):
        """Sets the compensation_methods of this KellerSensorData.


        :param compensation_methods: The compensation_methods of this KellerSensorData.  # noqa: E501
        :type: CompensationMethods
        """

        self._compensation_methods = compensation_methods

    @property
    def measurements(self):
        """Gets the measurements of this KellerSensorData.  # noqa: E501

        Array of individual measurements. Item order corresponds to order in measurement sequence.  # noqa: E501

        :return: The measurements of this KellerSensorData.  # noqa: E501
        :rtype: list[Measurement]
        """
        return self._measurements

    @measurements.setter
    def measurements(self, measurements):
        """Sets the measurements of this KellerSensorData.

        Array of individual measurements. Item order corresponds to order in measurement sequence.  # noqa: E501

        :param measurements: The measurements of this KellerSensorData.  # noqa: E501
        :type: list[Measurement]
        """

        self._measurements = measurements

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(KellerSensorData, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, KellerSensorData):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
